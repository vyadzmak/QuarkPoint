namespace QuarkPoint.Tester.UI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectTemplatePath = new System.Windows.Forms.Button();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectTempPath = new System.Windows.Forms.Button();
            this.txtTempPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectReportPath = new System.Windows.Forms.Button();
            this.txtReportPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "Выберите путь";
            this.fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь для хранения шаблонов";
            // 
            // btnSelectTemplatePath
            // 
            this.btnSelectTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTemplatePath.Location = new System.Drawing.Point(505, 23);
            this.btnSelectTemplatePath.Name = "btnSelectTemplatePath";
            this.btnSelectTemplatePath.Size = new System.Drawing.Size(42, 23);
            this.btnSelectTemplatePath.TabIndex = 14;
            this.btnSelectTemplatePath.Text = "...";
            this.btnSelectTemplatePath.UseVisualStyleBackColor = true;
            this.btnSelectTemplatePath.Click += new System.EventHandler(this.btnSelectTemplatePath_Click);
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplatePath.Location = new System.Drawing.Point(12, 25);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.ReadOnly = true;
            this.txtTemplatePath.Size = new System.Drawing.Size(487, 20);
            this.txtTemplatePath.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(457, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 27);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(361, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Путь для генерации временных элементов";
            // 
            // btnSelectTempPath
            // 
            this.btnSelectTempPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTempPath.Location = new System.Drawing.Point(505, 67);
            this.btnSelectTempPath.Name = "btnSelectTempPath";
            this.btnSelectTempPath.Size = new System.Drawing.Size(42, 23);
            this.btnSelectTempPath.TabIndex = 19;
            this.btnSelectTempPath.Text = "...";
            this.btnSelectTempPath.UseVisualStyleBackColor = true;
            this.btnSelectTempPath.Click += new System.EventHandler(this.btnSelectTempPath_Click);
            // 
            // txtTempPath
            // 
            this.txtTempPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTempPath.Location = new System.Drawing.Point(12, 69);
            this.txtTempPath.Name = "txtTempPath";
            this.txtTempPath.ReadOnly = true;
            this.txtTempPath.Size = new System.Drawing.Size(487, 20);
            this.txtTempPath.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Путь для генерации отчетов";
            // 
            // btnSelectReportPath
            // 
            this.btnSelectReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectReportPath.Location = new System.Drawing.Point(505, 117);
            this.btnSelectReportPath.Name = "btnSelectReportPath";
            this.btnSelectReportPath.Size = new System.Drawing.Size(42, 23);
            this.btnSelectReportPath.TabIndex = 22;
            this.btnSelectReportPath.Text = "...";
            this.btnSelectReportPath.UseVisualStyleBackColor = true;
            this.btnSelectReportPath.Click += new System.EventHandler(this.btnSelectReportPath_Click);
            // 
            // txtReportPath
            // 
            this.txtReportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportPath.Location = new System.Drawing.Point(12, 119);
            this.txtReportPath.Name = "txtReportPath";
            this.txtReportPath.ReadOnly = true;
            this.txtReportPath.Size = new System.Drawing.Size(487, 20);
            this.txtReportPath.TabIndex = 20;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectReportPath);
            this.Controls.Add(this.txtReportPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectTempPath);
            this.Controls.Add(this.txtTempPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectTemplatePath);
            this.Controls.Add(this.txtTemplatePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectTemplatePath;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectTempPath;
        private System.Windows.Forms.TextBox txtTempPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectReportPath;
        private System.Windows.Forms.TextBox txtReportPath;
    }
}