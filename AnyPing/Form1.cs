using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            textBoxResultDNS.Clear();
            textBoxResultICMP.Clear();
            textBoxResultTCP.Clear();
            textBoxResultTraceroute.Clear();
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
                traceroute(address)
            );
        }

        private async Task<IPAddress> resolveHostName(string hostName)
        {
            IPAddress.TryParse(hostName, out IPAddress address);
            if (address != null)
            {
                textBoxResultDNS.Text = $"Skip ({address.AddressFamily})";
                return address;
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
                PingReply reply = await ping.SendPingAsync(address, 2000);
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
                bool isConnected = result.AsyncWaitHandle.WaitOne(2000);
                timer.Stop();
                if (isConnected)
                {
                    client.EndConnect(result);
                    client.Close();
                    return $"Success ({timer.ElapsedMilliseconds} ms)";
                }
                else
                {
                    client.Close();
                    return "Failure (TimedOut)";
                }
            });

            textBoxResultTCP.Text = resultText;
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
            for (int i = 0; i < 20; i++)
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
                    PingReply reply = await ping.SendPingAsync(address, 1000, buffer, options);
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
            }

            textBoxResultTraceroute.AppendText("\r\nTrace completed.\r\n");
        }
    }
}
