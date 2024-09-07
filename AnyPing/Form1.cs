using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPing
{
    public partial class Form1 : Form
    {
        private int PingTimeoutMsec = Properties.Settings.Default.PingTimeoutMsec;
        private int TracerouteTimeoutMsec = Properties.Settings.Default.TracerouteTimeoutMsec;
        private int TracerouteMaxHops = Properties.Settings.Default.TracerouteMaxHops;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownPort_Enter(object sender, EventArgs e)
        {
            numericUpDownPort.Select(0, numericUpDownPort.Value.ToString().Length);
        }

        private void numericUpDownPort_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDownPort.Select(0, numericUpDownPort.Value.ToString().Length);
        }

        private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void buttonPing_Click(object sender, EventArgs e)
        {
            string hostName = textBoxHostname.Text;
            int tcpPort = Convert.ToInt32(numericUpDownPort.Value);

            buttonPing.Enabled = false;
            initResults();
            await doPing(hostName, tcpPort);
            buttonPing.Enabled = true;
        }

        private void initResults()
        {
            foreach (TextBox textbox in tableLayoutPanelResult.Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        private async Task doPing(string host, int tcpPort)
        {
            IPAddress address = await resolveHostName(host);
            if (address == null)
            {
                return;
            }

            await Task.WhenAll(
                sendICMP(address),
                sendTCP(address, tcpPort),
                sendHTTP(address, tcpPort, host, "http"),
                sendHTTP(address, tcpPort, host, "https"),
                traceroute(address)
            );
        }

        private async Task<IPAddress> resolveHostName(string hostName)
        {
            IPAddress.TryParse(hostName, out IPAddress address);
            if (address != null)
            {
                switch (address.AddressFamily)
                {
                    case AddressFamily.InterNetwork:
                        textBoxResultDNS.Text = "Skip (IPv4)";
                        return address;
                    case AddressFamily.InterNetworkV6:
                        textBoxResultDNS.Text = "Skip (IPv6)";
                        return address;
                    default:
                        textBoxResultDNS.Text = "Skip (InvalidAddress)";
                        return null;
                }
            }

            try
            {
                IPHostEntry reply = await Dns.GetHostEntryAsync(hostName);
                address = reply.AddressList[0];
                textBoxResultDNS.Text = $"Success ({address})";
                return address;
            }
            catch (SocketException ex)
            {
                textBoxResultDNS.Text = $"Failure ({ex.SocketErrorCode.ToString("g")})";
                return null;
            }
            catch (Exception ex)
            {
                textBoxResultDNS.Text = $"Failure ({ex.GetType().Name})";
                return null;
            }
        }
        private async Task sendICMP(IPAddress address)
        {
            if (address.Equals(IPAddress.Any))
            {
                textBoxResultICMP.Text = "Failure (Any)";
                return;
            }
            if (address.Equals(IPAddress.IPv6Any))
            {
                textBoxResultICMP.Text = "Failure (IPv6Any)";
                return;
            }

            string resultText;
            Ping ping = new Ping();
            try
            {
                PingReply reply = await ping.SendPingAsync(address, PingTimeoutMsec);
                if (reply.Status == IPStatus.Success)
                {
                    resultText = $"Success ({reply.RoundtripTime} ms)";
                }
                else
                {
                    resultText = $"Failure ({reply.Status.ToString("g")})";
                }
            }
            catch (PingException)
            {
                resultText = "Failure (PingException)";
            }
            catch (Exception ex)
            {
                resultText = $"Failure ({ex.GetType().Name})";
            }

            textBoxResultICMP.Text = resultText;
        }

        private async Task sendTCP(IPAddress address, int tcpPort)
        {
            if (tcpPort == 0)
            {
                textBoxResultTCP.Text = "Skip";
                return;
            }
            else if (tcpPort < 0 || tcpPort > 65535)
            {
                textBoxResultTCP.Text = "Failure (InvalidPortNumber)";
                return;
            }

            string resultText = await Task.Run(() =>
            {
                TcpClient client = new TcpClient(address.AddressFamily);
                Stopwatch timer = new Stopwatch();
                timer.Start();
                IAsyncResult result = client.BeginConnect(address, tcpPort, null, null);
                bool isConnected = result.AsyncWaitHandle.WaitOne(PingTimeoutMsec);
                timer.Stop();
                if (!isConnected)
                {
                    client.Close();
                    return "Failure (TimedOut)";
                }

                try
                {
                    client.EndConnect(result);
                    return $"Success ({timer.ElapsedMilliseconds} ms)";
                }
                catch (SocketException ex)
                {
                    return $"Failure ({ex.SocketErrorCode})";
                }
                catch (Exception ex)
                {
                    return $"Failure ({ex.GetType().Name})";
                }
                finally
                {
                    client.Close();

                }
            });

            textBoxResultTCP.Text = resultText;
        }

        private async Task sendHTTP(IPAddress address, int tcpPort, string host, string scheme)
        {
            CheckBox checkBox;
            TextBox textBoxResult;
            switch (scheme)
            {
                case "http":
                    checkBox = checkBoxHTTP;
                    textBoxResult = textBoxResultHTTP;
                    break;
                case "https":
                    checkBox = checkBoxHTTPS;
                    textBoxResult = textBoxResultHTTPS;
                    break;
                default:
                    return;
            }

            if (!checkBox.Checked)
            {
                textBoxResult.Text = "Skip";
                return;
            }

            if (tcpPort == 0)
            {
                textBoxResult.Text = "Skip";
                return;
            }
            else if (tcpPort < 0 || tcpPort > 65535)
            {
                textBoxResult.Text = "Failure (InvalidPortNumber)";
                return;
            }

            Uri uri = new UriBuilder(scheme, host, tcpPort).Uri;

            string resultText = await Task.Run(async () =>
            {
                HttpClient client = new HttpClient()
                {
                    Timeout = TimeSpan.FromMilliseconds(PingTimeoutMsec)
                };
                Stopwatch timer = new Stopwatch();
                timer.Start();
                try
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(uri);
                    timer.Stop();
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        return $"Success ({timer.ElapsedMilliseconds} ms; {(int)responseMessage.StatusCode} {responseMessage.ReasonPhrase})";
                    }
                    else
                    {
                        return $"Failure ({(int)responseMessage.StatusCode} {responseMessage.ReasonPhrase})";
                    }
                }
                catch (HttpRequestException ex) when (ex.InnerException is WebException wex)
                {
                    timer.Stop();
                    if (wex.Response is HttpWebResponse)
                    {
                        HttpWebResponse response = (HttpWebResponse)wex.Response;
                        return $"Failure ({(int)response.StatusCode} {response.StatusDescription})";
                    }
                    else
                    {
                        return $"Failure ({wex.Status})";
                    }
                }
                catch (TaskCanceledException)
                {
                    timer.Stop();
                    return $"Failure (TimedOut)";
                }
                catch (Exception ex)
                {
                    timer.Stop();
                    return $"Failure ({ex.GetType().Name})";
                }
                finally
                {
                    client.Dispose();
                }
            });

            textBoxResult.Text = resultText;
        }

        private async Task traceroute(IPAddress address)
        {
            if (!checkBoxTraceroute.Checked)
            {
                textBoxResultTraceroute.Text = "Skip";
                return;
            }

            if (address.Equals(IPAddress.Any))
            {
                textBoxResultTraceroute.Text = "Failure (Any)";
                return;
            }
            if (address.Equals(IPAddress.IPv6Any))
            {
                textBoxResultTraceroute.Text = "Failure (IPv6Any)";
                return;
            }

            Ping ping = new Ping();
            for (int i = 0; i < TracerouteMaxHops; i++)
            {
                PingOptions options = new PingOptions();
                options.Ttl = i + 1;
                string colTtl = options.Ttl.ToString().PadLeft(3, ' ');

                byte[] buffer = new byte[64];

                string resultText;
                try
                {
                    Stopwatch timer = new Stopwatch();
                    timer.Start();
                    PingReply reply = await ping.SendPingAsync(address, TracerouteTimeoutMsec, buffer, options);
                    timer.Stop();
                    string elapsedMsecs = timer.ElapsedMilliseconds.ToString().PadLeft(4, ' ');

                    if (reply.Status == IPStatus.Success)
                    {
                        resultText = $"{colTtl}  {elapsedMsecs} ms  {reply.Address}";
                        textBoxResultTraceroute.AppendText(resultText + "\r\n");
                        break;
                    }
                    else if (reply.Status == IPStatus.TtlExpired)
                    {
                        resultText = $"{colTtl}  {elapsedMsecs} ms  {reply.Address}";
                        textBoxResultTraceroute.AppendText(resultText + "\r\n");
                    }
                    else if (reply.Status == IPStatus.TimedOut)
                    {
                        resultText = $"{colTtl}     *     Request timed out.";
                        textBoxResultTraceroute.AppendText(resultText + "\r\n");
                    }
                    else
                    {
                        resultText = $"{colTtl}  Failure ({reply.Status.ToString("g")})";
                        textBoxResultTraceroute.AppendText(resultText + "\r\n");
                        return;
                    }
                }
                catch (PingException)
                {
                    resultText = $"{colTtl.PadLeft(3, ' ')}  Failure (PingException)";
                    textBoxResultTraceroute.AppendText(resultText + "\r\n");
                    return;
                }
                catch (Exception ex)
                {
                    resultText = $"{colTtl.PadLeft(3, ' ')}  Failure ({ex.GetType().Name})";
                    textBoxResultTraceroute.AppendText(resultText + "\r\n");
                    return;
                }
            }

            textBoxResultTraceroute.AppendText("\r\nTrace completed.\r\n");
        }
    }
}
