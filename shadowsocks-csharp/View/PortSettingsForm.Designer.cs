namespace Shadowsocks.View
{
    partial class PortSettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listPorts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkEnable = new System.Windows.Forms.CheckBox();
            this.textAddr = new System.Windows.Forms.TextBox();
            this.NumTargetPort = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboServers = new System.Windows.Forms.ComboBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.NumLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTargetPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLocalPort)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listPorts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listPorts
            // 
            this.listPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPorts.FormattingEnabled = true;
            this.listPorts.ItemHeight = 31;
            this.listPorts.Location = new System.Drawing.Point(3, 3);
            this.listPorts.Name = "listPorts";
            this.listPorts.Size = new System.Drawing.Size(144, 345);
            this.listPorts.TabIndex = 0;
            this.listPorts.SelectedIndexChanged += new System.EventHandler(this.listPorts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(153, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelID, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelAddr, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelPort, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkEnable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textAddr, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.NumTargetPort, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboServers, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelLocal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NumLocalPort, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textRemarks, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(579, 308);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelType.Location = new System.Drawing.Point(3, 42);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(164, 32);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelID.Location = new System.Drawing.Point(3, 87);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(164, 32);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Server ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddr.Location = new System.Drawing.Point(3, 176);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(164, 32);
            this.labelAddr.TabIndex = 0;
            this.labelAddr.Text = "Target Addr";
            this.labelAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPort.Location = new System.Drawing.Point(3, 220);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(164, 32);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Target Port";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkEnable
            // 
            this.checkEnable.AutoSize = true;
            this.checkEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkEnable.Location = new System.Drawing.Point(173, 3);
            this.checkEnable.Name = "checkEnable";
            this.checkEnable.Size = new System.Drawing.Size(403, 36);
            this.checkEnable.TabIndex = 3;
            this.checkEnable.Text = "Enable";
            this.checkEnable.UseVisualStyleBackColor = true;
            // 
            // textAddr
            // 
            this.textAddr.Dock = System.Windows.Forms.DockStyle.Top;
            this.textAddr.Location = new System.Drawing.Point(173, 179);
            this.textAddr.Name = "textAddr";
            this.textAddr.Size = new System.Drawing.Size(403, 38);
            this.textAddr.TabIndex = 7;
            // 
            // NumTargetPort
            // 
            this.NumTargetPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumTargetPort.Location = new System.Drawing.Point(173, 223);
            this.NumTargetPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumTargetPort.Name = "NumTargetPort";
            this.NumTargetPort.Size = new System.Drawing.Size(403, 38);
            this.NumTargetPort.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Port Forward",
            "Force Proxy",
            "Proxy With Rule"});
            this.comboBoxType.Location = new System.Drawing.Point(173, 45);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(403, 39);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboServers
            // 
            this.comboServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServers.FormattingEnabled = true;
            this.comboServers.Location = new System.Drawing.Point(173, 90);
            this.comboServers.Name = "comboServers";
            this.comboServers.Size = new System.Drawing.Size(403, 39);
            this.comboServers.TabIndex = 5;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLocal.Location = new System.Drawing.Point(3, 132);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(164, 32);
            this.labelLocal.TabIndex = 0;
            this.labelLocal.Text = "Local Port";
            this.labelLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumLocalPort
            // 
            this.NumLocalPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumLocalPort.Location = new System.Drawing.Point(173, 135);
            this.NumLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumLocalPort.Name = "NumLocalPort";
            this.NumLocalPort.Size = new System.Drawing.Size(403, 38);
            this.NumLocalPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remarks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textRemarks
            // 
            this.textRemarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.textRemarks.Location = new System.Drawing.Point(173, 267);
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(403, 38);
            this.textRemarks.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(153, 354);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(585, 54);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(286, 42);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.AutoSize = true;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyCancelButton.Location = new System.Drawing.Point(295, 3);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(287, 42);
            this.MyCancelButton.TabIndex = 11;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Del, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 96);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(22, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 42);
            this.Add.TabIndex = 1;
            this.Add.Text = "&Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Del
            // 
            this.Del.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Del.AutoSize = true;
            this.Del.Location = new System.Drawing.Point(18, 51);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(108, 42);
            this.Del.TabIndex = 2;
            this.Del.Text = "&Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // PortSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1056, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PortSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortMapForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTargetPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLocalPort)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listPorts;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.CheckBox checkEnable;
        private System.Windows.Forms.TextBox textAddr;
        private System.Windows.Forms.NumericUpDown NumTargetPort;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.NumericUpDown NumLocalPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRemarks;
    }
}