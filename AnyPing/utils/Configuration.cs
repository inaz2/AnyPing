using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPing.utils
{
    internal class Configuration
    {
        // { minimum, maximum, initial }
        public static readonly int[] DefPingTimeoutMsec = new int[] { 1000, 60000, 2000 };
        public static readonly int[] DefTracerouteTimeoutMsec = new int[] { 1000, 60000, 1000 };
        public static readonly int[] DefTracerouteMaxHops = new int[] { 1, 100, 20 };

        public static int PingTimeoutMsec
        {
            get
            {
                return Properties.Settings.Default.PingTimeoutMsec;
            }
            set
            {
                Properties.Settings.Default.PingTimeoutMsec = Conversion.Clamp(value, DefPingTimeoutMsec[0], DefPingTimeoutMsec[1]);
            }
        }

        public static int TracerouteTimeoutMsec
        {
            get
            {
                return Properties.Settings.Default.TracerouteTimeoutMsec;
            }
            set
            {
                Properties.Settings.Default.TracerouteTimeoutMsec = Conversion.Clamp(value, DefTracerouteTimeoutMsec[0], DefTracerouteTimeoutMsec[1]);
            }
        }

        public static int TracerouteMaxHops
        {
            get
            {
                return Properties.Settings.Default.TracerouteMaxHops;
            }
            set
            {
                Properties.Settings.Default.TracerouteMaxHops = Conversion.Clamp(value, DefTracerouteMaxHops[0], DefTracerouteMaxHops[1]);
            }
        }

        public static bool SendProxyCredential
        {
            get
            {
                return Properties.Settings.Default.SendProxyCredential;
            }
            set
            {
                Properties.Settings.Default.SendProxyCredential = value;
            }
        }


        public static string ProxyUsername
        {
            get
            {
                return Conversion.Unprotect(Properties.Settings.Default.ProxyUsername);
            }
            set
            {
                Properties.Settings.Default.ProxyUsername = Conversion.Protect(value);
            }
        }

        public static string ProxyPassword
        {
            get
            {
                return Conversion.Unprotect(Properties.Settings.Default.ProxyPassword);
            }
            set
            {
                Properties.Settings.Default.ProxyPassword = Conversion.Protect(value);
            }
        }

        public static void Validate()
        {
            bool isInvalid = false;

            if (PingTimeoutMsec < DefPingTimeoutMsec[0] || PingTimeoutMsec > DefPingTimeoutMsec[1])
            {
                isInvalid = true;
            }
            if (TracerouteTimeoutMsec < DefTracerouteTimeoutMsec[0] || TracerouteTimeoutMsec > DefTracerouteTimeoutMsec[1])
            {
                isInvalid = true;
            }
            if (TracerouteMaxHops < DefTracerouteMaxHops[0] || TracerouteMaxHops > DefTracerouteMaxHops[1])
            {
                isInvalid = true;
            }

            if (isInvalid)
            {
                MessageBox.Show("設定ファイルの読み込みに失敗しました。初期設定状態に戻します。", "AnyPing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Configuration.Reset();
                Configuration.Save();
            }
        }

        public static void Reset()
        {
            Configuration.PingTimeoutMsec = DefPingTimeoutMsec[2];
            Configuration.TracerouteTimeoutMsec = DefTracerouteTimeoutMsec[2];
            Configuration.TracerouteMaxHops = DefTracerouteMaxHops[2];
            Configuration.SendProxyCredential = false;
            Configuration.ProxyUsername = "";
            Configuration.ProxyPassword = "";
        }

        public static void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
