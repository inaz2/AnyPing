namespace AnyPing
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ウィンドウWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.buttonPing = new System.Windows.Forms.Button();
            this.checkBoxTraceroute = new System.Windows.Forms.CheckBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelResult = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxResultHTTPS = new System.Windows.Forms.TextBox();
            this.labelResultHTTPS = new System.Windows.Forms.Label();
            this.textBoxResultHTTP = new System.Windows.Forms.TextBox();
            this.labelResultHTTP = new System.Windows.Forms.Label();
            this.labelResultDNS = new System.Windows.Forms.Label();
            this.textBoxResultDNS = new System.Windows.Forms.TextBox();
            this.labelResultICMP = new System.Windows.Forms.Label();
            this.textBoxResultICMP = new System.Windows.Forms.TextBox();
            this.labelResultTCP = new System.Windows.Forms.Label();
            this.textBoxResultTCP = new System.Windows.Forms.TextBox();
            this.labelResultTraceroute = new System.Windows.Forms.Label();
            this.textBoxResultTraceroute = new System.Windows.Forms.TextBox();
            this.checkBoxHTTP = new System.Windows.Forms.CheckBox();
            this.checkBoxHTTPS = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.tableLayoutPanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ウィンドウWToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(524, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ウィンドウWToolStripMenuItem
            // 
            this.ウィンドウWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オプションOToolStripMenuItem,
            this.バージョン情報VToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ウィンドウWToolStripMenuItem.Name = "ウィンドウWToolStripMenuItem";
            this.ウィンドウWToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.ウィンドウWToolStripMenuItem.Text = "ウィンドウ (&W)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.オプションOToolStripMenuItem.Text = "オプション (&O)...";
            this.オプションOToolStripMenuItem.Click += new System.EventHandler(this.オプションOToolStripMenuItem_Click);
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報 (&V)";
            this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報VToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.終了XToolStripMenuItem.Text = "終了 (&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(6, 21);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 15);
            this.labelHost.TabIndex = 1;
            this.labelHost.Text = "Host";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(52, 19);
            this.textBoxHostname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(357, 23);
            this.textBoxHostname.TabIndex = 2;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(415, 19);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(78, 23);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Enter += new System.EventHandler(this.numericUpDownPort_Enter);
            this.numericUpDownPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPort_MouseUp);
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(52, 53);
            this.buttonPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(100, 33);
            this.buttonPing.TabIndex = 4;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // checkBoxTraceroute
            // 
            this.checkBoxTraceroute.AutoSize = true;
            this.checkBoxTraceroute.Location = new System.Drawing.Point(293, 61);
            this.checkBoxTraceroute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTraceroute.Name = "checkBoxTraceroute";
            this.checkBoxTraceroute.Size = new System.Drawing.Size(81, 19);
            this.checkBoxTraceroute.TabIndex = 7;
            this.checkBoxTraceroute.Text = "Traceroute";
            this.checkBoxTraceroute.UseVisualStyleBackColor = true;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanelResult);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult.Size = new System.Drawing.Size(500, 517);
            this.groupBoxResult.TabIndex = 8;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // tableLayoutPanelResult
            // 
            this.tableLayoutPanelResult.ColumnCount = 2;
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultHTTPS, 1, 4);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultHTTPS, 0, 4);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultHTTP, 1, 3);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultHTTP, 0, 3);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultDNS, 0, 0);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultDNS, 1, 0);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultICMP, 0, 1);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultICMP, 1, 1);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultTCP, 0, 2);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultTCP, 1, 2);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultTraceroute, 0, 5);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultTraceroute, 1, 5);
            this.tableLayoutPanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResult.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanelResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelResult.Name = "tableLayoutPanelResult";
            this.tableLayoutPanelResult.RowCount = 6;
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelResult.Size = new System.Drawing.Size(494, 493);
            this.tableLayoutPanelResult.TabIndex = 0;
            // 
            // textBoxResultHTTPS
            // 
            this.textBoxResultHTTPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultHTTPS.Location = new System.Drawing.Point(71, 128);
            this.textBoxResultHTTPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultHTTPS.Name = "textBoxResultHTTPS";
            this.textBoxResultHTTPS.ReadOnly = true;
            this.textBoxResultHTTPS.Size = new System.Drawing.Size(420, 23);
            this.textBoxResultHTTPS.TabIndex = 9;
            // 
            // labelResultHTTPS
            // 
            this.labelResultHTTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultHTTPS.AutoSize = true;
            this.labelResultHTTPS.Location = new System.Drawing.Point(3, 132);
            this.labelResultHTTPS.Name = "labelResultHTTPS";
            this.labelResultHTTPS.Size = new System.Drawing.Size(41, 15);
            this.labelResultHTTPS.TabIndex = 8;
            this.labelResultHTTPS.Text = "HTTPS";
            // 
            // textBoxResultHTTP
            // 
            this.textBoxResultHTTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultHTTP.Location = new System.Drawing.Point(71, 97);
            this.textBoxResultHTTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultHTTP.Name = "textBoxResultHTTP";
            this.textBoxResultHTTP.ReadOnly = true;
            this.textBoxResultHTTP.Size = new System.Drawing.Size(420, 23);
            this.textBoxResultHTTP.TabIndex = 7;
            // 
            // labelResultHTTP
            // 
            this.labelResultHTTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultHTTP.AutoSize = true;
            this.labelResultHTTP.Location = new System.Drawing.Point(3, 101);
            this.labelResultHTTP.Name = "labelResultHTTP";
            this.labelResultHTTP.Size = new System.Drawing.Size(35, 15);
            this.labelResultHTTP.TabIndex = 6;
            this.labelResultHTTP.Text = "HTTP";
            // 
            // labelResultDNS
            // 
            this.labelResultDNS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultDNS.AutoSize = true;
            this.labelResultDNS.Location = new System.Drawing.Point(3, 8);
            this.labelResultDNS.Name = "labelResultDNS";
            this.labelResultDNS.Size = new System.Drawing.Size(30, 15);
            this.labelResultDNS.TabIndex = 0;
            this.labelResultDNS.Text = "DNS";
            // 
            // textBoxResultDNS
            // 
            this.textBoxResultDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultDNS.Location = new System.Drawing.Point(71, 4);
            this.textBoxResultDNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultDNS.Name = "textBoxResultDNS";
            this.textBoxResultDNS.ReadOnly = true;
            this.textBoxResultDNS.Size = new System.Drawing.Size(420, 23);
            this.textBoxResultDNS.TabIndex = 1;
            // 
            // labelResultICMP
            // 
            this.labelResultICMP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultICMP.AutoSize = true;
            this.labelResultICMP.Location = new System.Drawing.Point(3, 39);
            this.labelResultICMP.Name = "labelResultICMP";
            this.labelResultICMP.Size = new System.Drawing.Size(35, 15);
            this.labelResultICMP.TabIndex = 2;
            this.labelResultICMP.Text = "ICMP";
            // 
            // textBoxResultICMP
            // 
            this.textBoxResultICMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultICMP.Location = new System.Drawing.Point(71, 35);
            this.textBoxResultICMP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultICMP.Name = "textBoxResultICMP";
            this.textBoxResultICMP.ReadOnly = true;
            this.textBoxResultICMP.Size = new System.Drawing.Size(420, 23);
            this.textBoxResultICMP.TabIndex = 3;
            // 
            // labelResultTCP
            // 
            this.labelResultTCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultTCP.AutoSize = true;
            this.labelResultTCP.Location = new System.Drawing.Point(3, 70);
            this.labelResultTCP.Name = "labelResultTCP";
            this.labelResultTCP.Size = new System.Drawing.Size(27, 15);
            this.labelResultTCP.TabIndex = 4;
            this.labelResultTCP.Text = "TCP";
            // 
            // textBoxResultTCP
            // 
            this.textBoxResultTCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultTCP.Location = new System.Drawing.Point(71, 66);
            this.textBoxResultTCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultTCP.Name = "textBoxResultTCP";
            this.textBoxResultTCP.ReadOnly = true;
            this.textBoxResultTCP.Size = new System.Drawing.Size(420, 23);
            this.textBoxResultTCP.TabIndex = 5;
            // 
            // labelResultTraceroute
            // 
            this.labelResultTraceroute.AutoSize = true;
            this.labelResultTraceroute.Location = new System.Drawing.Point(3, 163);
            this.labelResultTraceroute.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelResultTraceroute.Name = "labelResultTraceroute";
            this.labelResultTraceroute.Size = new System.Drawing.Size(62, 15);
            this.labelResultTraceroute.TabIndex = 10;
            this.labelResultTraceroute.Text = "Traceroute";
            // 
            // textBoxResultTraceroute
            // 
            this.textBoxResultTraceroute.AcceptsReturn = true;
            this.textBoxResultTraceroute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultTraceroute.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultTraceroute.Location = new System.Drawing.Point(71, 159);
            this.textBoxResultTraceroute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultTraceroute.Multiline = true;
            this.textBoxResultTraceroute.Name = "textBoxResultTraceroute";
            this.textBoxResultTraceroute.ReadOnly = true;
            this.textBoxResultTraceroute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultTraceroute.Size = new System.Drawing.Size(420, 330);
            this.textBoxResultTraceroute.TabIndex = 11;
            // 
            // checkBoxHTTP
            // 
            this.checkBoxHTTP.AutoSize = true;
            this.checkBoxHTTP.Location = new System.Drawing.Point(167, 61);
            this.checkBoxHTTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHTTP.Name = "checkBoxHTTP";
            this.checkBoxHTTP.Size = new System.Drawing.Size(54, 19);
            this.checkBoxHTTP.TabIndex = 5;
            this.checkBoxHTTP.Text = "HTTP";
            this.checkBoxHTTP.UseVisualStyleBackColor = true;
            // 
            // checkBoxHTTPS
            // 
            this.checkBoxHTTPS.AutoSize = true;
            this.checkBoxHTTPS.Location = new System.Drawing.Point(227, 61);
            this.checkBoxHTTPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHTTPS.Name = "checkBoxHTTPS";
            this.checkBoxHTTPS.Size = new System.Drawing.Size(60, 19);
            this.checkBoxHTTPS.TabIndex = 6;
            this.checkBoxHTTPS.Text = "HTTPS";
            this.checkBoxHTTPS.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelHost);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxHTTPS);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxHostname);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownPort);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxHTTP);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPing);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxTraceroute);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxResult);
            this.splitContainer1.Size = new System.Drawing.Size(500, 621);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonPing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AnyPing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.tableLayoutPanelResult.ResumeLayout(false);
            this.tableLayoutPanelResult.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ウィンドウWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.CheckBox checkBoxTraceroute;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResult;
        private System.Windows.Forms.Label labelResultDNS;
        private System.Windows.Forms.TextBox textBoxResultDNS;
        private System.Windows.Forms.Label labelResultICMP;
        private System.Windows.Forms.TextBox textBoxResultICMP;
        private System.Windows.Forms.Label labelResultTCP;
        private System.Windows.Forms.TextBox textBoxResultTCP;
        private System.Windows.Forms.Label labelResultTraceroute;
        private System.Windows.Forms.TextBox textBoxResultTraceroute;
        private System.Windows.Forms.CheckBox checkBoxHTTPS;
        private System.Windows.Forms.CheckBox checkBoxHTTP;
        private System.Windows.Forms.TextBox textBoxResultHTTPS;
        private System.Windows.Forms.Label labelResultHTTPS;
        private System.Windows.Forms.TextBox textBoxResultHTTP;
        private System.Windows.Forms.Label labelResultHTTP;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

