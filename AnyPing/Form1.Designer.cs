﻿namespace AnyPing
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
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.buttonPing = new System.Windows.Forms.Button();
            this.checkBoxTraceroute = new System.Windows.Forms.CheckBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelResult = new System.Windows.Forms.TableLayoutPanel();
            this.labelResultDNS = new System.Windows.Forms.Label();
            this.textBoxResultDNS = new System.Windows.Forms.TextBox();
            this.labelResultICMP = new System.Windows.Forms.Label();
            this.textBoxResultICMP = new System.Windows.Forms.TextBox();
            this.labelResultTCP = new System.Windows.Forms.Label();
            this.textBoxResultTCP = new System.Windows.Forms.TextBox();
            this.labelResultTraceroute = new System.Windows.Forms.Label();
            this.textBoxResultTraceroute = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.tableLayoutPanelResult.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(623, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ウィンドウWToolStripMenuItem
            // 
            this.ウィンドウWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ウィンドウWToolStripMenuItem.Name = "ウィンドウWToolStripMenuItem";
            this.ウィンドウWToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ウィンドウWToolStripMenuItem.Text = "ウィンドウ (&W)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報 (&V)";
            this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報VToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.終了XToolStripMenuItem.Text = "終了 (&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(33, 62);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(40, 20);
            this.labelHost.TabIndex = 1;
            this.labelHost.Text = "Host";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(79, 59);
            this.textBoxHostname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(424, 27);
            this.textBoxHostname.TabIndex = 2;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(509, 59);
            this.numericUpDownPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(78, 27);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Enter += new System.EventHandler(this.numericUpDownPort_Enter);
            this.numericUpDownPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPort_MouseUp);
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(79, 92);
            this.buttonPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(94, 29);
            this.buttonPing.TabIndex = 4;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // checkBoxTraceroute
            // 
            this.checkBoxTraceroute.AutoSize = true;
            this.checkBoxTraceroute.Location = new System.Drawing.Point(179, 95);
            this.checkBoxTraceroute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTraceroute.Name = "checkBoxTraceroute";
            this.checkBoxTraceroute.Size = new System.Drawing.Size(100, 24);
            this.checkBoxTraceroute.TabIndex = 5;
            this.checkBoxTraceroute.Text = "Traceroute";
            this.checkBoxTraceroute.UseVisualStyleBackColor = true;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanelResult);
            this.groupBoxResult.Location = new System.Drawing.Point(23, 141);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxResult.Size = new System.Drawing.Size(576, 581);
            this.groupBoxResult.TabIndex = 6;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // tableLayoutPanelResult
            // 
            this.tableLayoutPanelResult.ColumnCount = 2;
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelResult.Controls.Add(this.labelResultDNS, 0, 0);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultDNS, 1, 0);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultICMP, 0, 1);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultICMP, 1, 1);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultTCP, 0, 2);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultTCP, 1, 2);
            this.tableLayoutPanelResult.Controls.Add(this.labelResultTraceroute, 0, 3);
            this.tableLayoutPanelResult.Controls.Add(this.textBoxResultTraceroute, 1, 3);
            this.tableLayoutPanelResult.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanelResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelResult.Name = "tableLayoutPanelResult";
            this.tableLayoutPanelResult.RowCount = 4;
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelResult.Size = new System.Drawing.Size(562, 540);
            this.tableLayoutPanelResult.TabIndex = 0;
            // 
            // labelResultDNS
            // 
            this.labelResultDNS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultDNS.AutoSize = true;
            this.labelResultDNS.Location = new System.Drawing.Point(3, 7);
            this.labelResultDNS.Name = "labelResultDNS";
            this.labelResultDNS.Size = new System.Drawing.Size(39, 20);
            this.labelResultDNS.TabIndex = 0;
            this.labelResultDNS.Text = "DNS";
            // 
            // textBoxResultDNS
            // 
            this.textBoxResultDNS.Location = new System.Drawing.Point(87, 4);
            this.textBoxResultDNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultDNS.Name = "textBoxResultDNS";
            this.textBoxResultDNS.Size = new System.Drawing.Size(472, 27);
            this.textBoxResultDNS.TabIndex = 1;
            // 
            // labelResultICMP
            // 
            this.labelResultICMP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultICMP.AutoSize = true;
            this.labelResultICMP.Location = new System.Drawing.Point(3, 42);
            this.labelResultICMP.Name = "labelResultICMP";
            this.labelResultICMP.Size = new System.Drawing.Size(43, 20);
            this.labelResultICMP.TabIndex = 2;
            this.labelResultICMP.Text = "ICMP";
            // 
            // textBoxResultICMP
            // 
            this.textBoxResultICMP.Location = new System.Drawing.Point(87, 39);
            this.textBoxResultICMP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultICMP.Name = "textBoxResultICMP";
            this.textBoxResultICMP.Size = new System.Drawing.Size(472, 27);
            this.textBoxResultICMP.TabIndex = 3;
            // 
            // labelResultTCP
            // 
            this.labelResultTCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultTCP.AutoSize = true;
            this.labelResultTCP.Location = new System.Drawing.Point(3, 77);
            this.labelResultTCP.Name = "labelResultTCP";
            this.labelResultTCP.Size = new System.Drawing.Size(34, 20);
            this.labelResultTCP.TabIndex = 4;
            this.labelResultTCP.Text = "TCP";
            // 
            // textBoxResultTCP
            // 
            this.textBoxResultTCP.Location = new System.Drawing.Point(87, 74);
            this.textBoxResultTCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultTCP.Name = "textBoxResultTCP";
            this.textBoxResultTCP.Size = new System.Drawing.Size(472, 27);
            this.textBoxResultTCP.TabIndex = 5;
            // 
            // labelResultTraceroute
            // 
            this.labelResultTraceroute.AutoSize = true;
            this.labelResultTraceroute.Location = new System.Drawing.Point(3, 113);
            this.labelResultTraceroute.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelResultTraceroute.Name = "labelResultTraceroute";
            this.labelResultTraceroute.Size = new System.Drawing.Size(78, 20);
            this.labelResultTraceroute.TabIndex = 6;
            this.labelResultTraceroute.Text = "Traceroute";
            // 
            // textBoxResultTraceroute
            // 
            this.textBoxResultTraceroute.AcceptsReturn = true;
            this.textBoxResultTraceroute.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultTraceroute.Location = new System.Drawing.Point(87, 109);
            this.textBoxResultTraceroute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultTraceroute.Multiline = true;
            this.textBoxResultTraceroute.Name = "textBoxResultTraceroute";
            this.textBoxResultTraceroute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultTraceroute.Size = new System.Drawing.Size(472, 424);
            this.textBoxResultTraceroute.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonPing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 779);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.checkBoxTraceroute);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.textBoxHostname);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "AnyPing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.tableLayoutPanelResult.ResumeLayout(false);
            this.tableLayoutPanelResult.PerformLayout();
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
    }
}

