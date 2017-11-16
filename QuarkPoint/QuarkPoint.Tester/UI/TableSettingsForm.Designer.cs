namespace QuarkPoint.Tester.UI
{
    partial class TableSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSettingsForm));
            this.pMainTableSetting = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbTableType = new System.Windows.Forms.ComboBox();
            this.lblTableType = new System.Windows.Forms.Label();
            this.pDetails = new System.Windows.Forms.Panel();
            this.chbUseHeaders = new System.Windows.Forms.CheckBox();
            this.chbUseFooters = new System.Windows.Forms.CheckBox();
            this.pMainTableSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMainTableSetting
            // 
            this.pMainTableSetting.Controls.Add(this.chbUseFooters);
            this.pMainTableSetting.Controls.Add(this.chbUseHeaders);
            this.pMainTableSetting.Controls.Add(this.btnApply);
            this.pMainTableSetting.Controls.Add(this.cbTableType);
            this.pMainTableSetting.Controls.Add(this.lblTableType);
            this.pMainTableSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainTableSetting.Location = new System.Drawing.Point(0, 0);
            this.pMainTableSetting.Name = "pMainTableSetting";
            this.pMainTableSetting.Size = new System.Drawing.Size(419, 139);
            this.pMainTableSetting.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(341, 29);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbTableType
            // 
            this.cbTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableType.FormattingEnabled = true;
            this.cbTableType.Location = new System.Drawing.Point(15, 29);
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(320, 21);
            this.cbTableType.TabIndex = 3;
            // 
            // lblTableType
            // 
            this.lblTableType.AutoSize = true;
            this.lblTableType.Location = new System.Drawing.Point(12, 13);
            this.lblTableType.Name = "lblTableType";
            this.lblTableType.Size = new System.Drawing.Size(72, 13);
            this.lblTableType.TabIndex = 2;
            this.lblTableType.Text = "Тип таблицы";
            // 
            // pDetails
            // 
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetails.Location = new System.Drawing.Point(0, 139);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(419, 227);
            this.pDetails.TabIndex = 3;
            // 
            // chbUseHeaders
            // 
            this.chbUseHeaders.AutoSize = true;
            this.chbUseHeaders.Location = new System.Drawing.Point(15, 70);
            this.chbUseHeaders.Name = "chbUseHeaders";
            this.chbUseHeaders.Size = new System.Drawing.Size(140, 17);
            this.chbUseHeaders.TabIndex = 5;
            this.chbUseHeaders.Text = "Использовать headers";
            this.chbUseHeaders.UseVisualStyleBackColor = true;
            // 
            // chbUseFooters
            // 
            this.chbUseFooters.AutoSize = true;
            this.chbUseFooters.Location = new System.Drawing.Point(15, 93);
            this.chbUseFooters.Name = "chbUseFooters";
            this.chbUseFooters.Size = new System.Drawing.Size(134, 17);
            this.chbUseFooters.TabIndex = 6;
            this.chbUseFooters.Text = "Использовать footers";
            this.chbUseFooters.UseVisualStyleBackColor = true;
            // 
            // TableSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 366);
            this.Controls.Add(this.pDetails);
            this.Controls.Add(this.pMainTableSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Натройки таблицы";
            this.Shown += new System.EventHandler(this.TableSettingsForm_Shown);
            this.pMainTableSetting.ResumeLayout(false);
            this.pMainTableSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMainTableSetting;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbTableType;
        private System.Windows.Forms.Label lblTableType;
        public System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.CheckBox chbUseFooters;
        private System.Windows.Forms.CheckBox chbUseHeaders;
    }
}