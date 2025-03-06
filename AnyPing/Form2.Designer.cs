namespace AnyPing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPingTimeoutMsec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxProxyUsername = new System.Windows.Forms.TextBox();
            this.textBoxProxyPassword = new System.Windows.Forms.TextBox();
            this.checkBoxSendProxyCredential = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTracerouteMaxHops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTracerouteTimeoutMsec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeoutMsec)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTracerouteMaxHops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTracerouteTimeoutMsec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPingTimeoutMsec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(391, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全般";
            // 
            // numericUpDownPingTimeoutMsec
            // 
            this.numericUpDownPingTimeoutMsec.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingTimeoutMsec.Location = new System.Drawing.Point(251, 23);
            this.numericUpDownPingTimeoutMsec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownPingTimeoutMsec.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownPingTimeoutMsec.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingTimeoutMsec.Name = "numericUpDownPingTimeoutMsec";
            this.numericUpDownPingTimeoutMsec.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPingTimeoutMsec.TabIndex = 1;
            this.numericUpDownPingTimeoutMsec.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイムアウト時間（ミリ秒）";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProxyUsername);
            this.groupBox2.Controls.Add(this.textBoxProxyPassword);
            this.groupBox2.Controls.Add(this.checkBoxSendProxyCredential);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(391, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTTPプロキシ";
            // 
            // textBoxProxyUsername
            // 
            this.textBoxProxyUsername.Enabled = false;
            this.textBoxProxyUsername.Location = new System.Drawing.Point(89, 59);
            this.textBoxProxyUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProxyUsername.Name = "textBoxProxyUsername";
            this.textBoxProxyUsername.Size = new System.Drawing.Size(281, 23);
            this.textBoxProxyUsername.TabIndex = 2;
            // 
            // textBoxProxyPassword
            // 
            this.textBoxProxyPassword.Enabled = false;
            this.textBoxProxyPassword.Location = new System.Drawing.Point(89, 91);
            this.textBoxProxyPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProxyPassword.Name = "textBoxProxyPassword";
            this.textBoxProxyPassword.PasswordChar = '*';
            this.textBoxProxyPassword.Size = new System.Drawing.Size(281, 23);
            this.textBoxProxyPassword.TabIndex = 4;
            // 
            // checkBoxSendProxyCredential
            // 
            this.checkBoxSendProxyCredential.AutoSize = true;
            this.checkBoxSendProxyCredential.Location = new System.Drawing.Point(22, 28);
            this.checkBoxSendProxyCredential.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSendProxyCredential.Name = "checkBoxSendProxyCredential";
            this.checkBoxSendProxyCredential.Size = new System.Drawing.Size(126, 19);
            this.checkBoxSendProxyCredential.TabIndex = 0;
            this.checkBoxSendProxyCredential.Text = "認証情報を送信する";
            this.checkBoxSendProxyCredential.UseVisualStyleBackColor = true;
            this.checkBoxSendProxyCredential.CheckedChanged += new System.EventHandler(this.checkBoxSendProxyCredential_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "パスワード";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ユーザ名";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(62, 325);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 33);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "適用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(274, 325);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(168, 325);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 33);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownTracerouteMaxHops);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownTracerouteTimeoutMsec);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(21, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(391, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Traceroute";
            // 
            // numericUpDownTracerouteMaxHops
            // 
            this.numericUpDownTracerouteMaxHops.Location = new System.Drawing.Point(250, 56);
            this.numericUpDownTracerouteMaxHops.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownTracerouteMaxHops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTracerouteMaxHops.Name = "numericUpDownTracerouteMaxHops";
            this.numericUpDownTracerouteMaxHops.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTracerouteMaxHops.TabIndex = 3;
            this.numericUpDownTracerouteMaxHops.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "最大ホップ数";
            // 
            // numericUpDownTracerouteTimeoutMsec
            // 
            this.numericUpDownTracerouteTimeoutMsec.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTracerouteTimeoutMsec.Location = new System.Drawing.Point(250, 25);
            this.numericUpDownTracerouteTimeoutMsec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownTracerouteTimeoutMsec.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownTracerouteTimeoutMsec.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTracerouteTimeoutMsec.Name = "numericUpDownTracerouteTimeoutMsec";
            this.numericUpDownTracerouteTimeoutMsec.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTracerouteTimeoutMsec.TabIndex = 1;
            this.numericUpDownTracerouteTimeoutMsec.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "タイムアウト時間（ミリ秒）";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "オプション";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeoutMsec)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTracerouteMaxHops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTracerouteTimeoutMsec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPingTimeoutMsec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSendProxyCredential;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProxyUsername;
        private System.Windows.Forms.TextBox textBoxProxyPassword;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownTracerouteMaxHops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTracerouteTimeoutMsec;
        private System.Windows.Forms.Label label2;
    }
}