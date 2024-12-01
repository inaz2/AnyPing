using AnyPing.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDownPingTimeoutMsec.Minimum = Configuration.DefPingTimeoutMsec[0];
            numericUpDownPingTimeoutMsec.Maximum = Configuration.DefPingTimeoutMsec[1];
            numericUpDownTracerouteTimeoutMsec.Minimum = Configuration.DefTracerouteTimeoutMsec[0];
            numericUpDownTracerouteTimeoutMsec.Maximum = Configuration.DefTracerouteTimeoutMsec[1];
            numericUpDownTracerouteMaxHops.Minimum = Configuration.DefTracerouteMaxHops[0];
            numericUpDownTracerouteMaxHops.Maximum = Configuration.DefTracerouteMaxHops[1];

            LoadConfiguration();
        }

        private void checkBoxSendProxyCredential_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxSendProxyCredential.Checked;
            textBoxProxyUsername.Enabled = isChecked;
            textBoxProxyPassword.Enabled = isChecked;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Configuration.PingTimeoutMsec = decimal.ToInt32(numericUpDownPingTimeoutMsec.Value);
            Configuration.TracerouteTimeoutMsec = decimal.ToInt32(numericUpDownTracerouteTimeoutMsec.Value);
            Configuration.TracerouteMaxHops = decimal.ToInt32(numericUpDownTracerouteMaxHops.Value);
            Configuration.SendProxyCredential = checkBoxSendProxyCredential.Checked;
            Configuration.ProxyUsername = textBoxProxyUsername.Text;
            Configuration.ProxyPassword = textBoxProxyPassword.Text;

            Configuration.Save();

            this.Dispose();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Configuration.Reset();

            LoadConfiguration();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadConfiguration()
        {
            numericUpDownPingTimeoutMsec.Value = Configuration.PingTimeoutMsec;
            numericUpDownTracerouteTimeoutMsec.Value = Configuration.TracerouteTimeoutMsec;
            numericUpDownTracerouteMaxHops.Value = Configuration.TracerouteMaxHops;
            checkBoxSendProxyCredential.Checked = Configuration.SendProxyCredential;
            textBoxProxyUsername.Text = Configuration.ProxyUsername;
            textBoxProxyPassword.Text = Configuration.ProxyPassword;
        }
    }
}
