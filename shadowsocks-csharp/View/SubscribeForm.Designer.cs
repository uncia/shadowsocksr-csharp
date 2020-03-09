namespace Shadowsocks.View
{
    partial class SubscribeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUpdate = new System.Windows.Forms.TextBox();
            this.checkBoxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listServerSubscribe = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxURL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGroup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textUpdate, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(882, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxURL.Location = new System.Drawing.Point(196, 8);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(522, 38);
            this.textBoxURL.TabIndex = 1;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxGroup.Location = new System.Drawing.Point(196, 62);
            this.textBoxGroup.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(522, 38);
            this.textBoxGroup.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Update";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textUpdate
            // 
            this.textUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.textUpdate.Location = new System.Drawing.Point(196, 116);
            this.textUpdate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textUpdate.Name = "textUpdate";
            this.textUpdate.ReadOnly = true;
            this.textUpdate.Size = new System.Drawing.Size(522, 38);
            this.textUpdate.TabIndex = 1;
            // 
            // checkBoxAutoUpdate
            // 
            this.checkBoxAutoUpdate.AutoSize = true;
            this.checkBoxAutoUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxAutoUpdate.Location = new System.Drawing.Point(8, 89);
            this.checkBoxAutoUpdate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.checkBoxAutoUpdate.Name = "checkBoxAutoUpdate";
            this.checkBoxAutoUpdate.Size = new System.Drawing.Size(413, 36);
            this.checkBoxAutoUpdate.TabIndex = 3;
            this.checkBoxAutoUpdate.Text = "Auto update";
            this.checkBoxAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(882, 628);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 114);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOK.Location = new System.Drawing.Point(8, 8);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(347, 98);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancel.Location = new System.Drawing.Point(371, 8);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(347, 98);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.listServerSubscribe, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(30, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1615, 818);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // listServerSubscribe
            // 
            this.listServerSubscribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listServerSubscribe.FormattingEnabled = true;
            this.listServerSubscribe.ItemHeight = 31;
            this.listServerSubscribe.Location = new System.Drawing.Point(8, 8);
            this.listServerSubscribe.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.listServerSubscribe.Name = "listServerSubscribe";
            this.listServerSubscribe.Size = new System.Drawing.Size(858, 604);
            this.listServerSubscribe.TabIndex = 4;
            this.listServerSubscribe.SelectedIndexChanged += new System.EventHandler(this.listServerSubscribe_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxAutoUpdate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonDel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 628);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(858, 162);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.Location = new System.Drawing.Point(8, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(413, 58);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDel.Location = new System.Drawing.Point(437, 8);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(413, 58);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1702, 910);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "SubscribeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subscribe Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubscribeForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listServerSubscribe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUpdate;
    }
}