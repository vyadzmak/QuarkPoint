namespace QuarkPoint.Tester.UI
{
    partial class NewElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewElementForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbElementType = new System.Windows.Forms.ComboBox();
            this.lbElementType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(336, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(15, 35);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(396, 20);
            this.txtElementName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Имя элемента";
            // 
            // cbElementType
            // 
            this.cbElementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElementType.FormattingEnabled = true;
            this.cbElementType.Location = new System.Drawing.Point(15, 96);
            this.cbElementType.Name = "cbElementType";
            this.cbElementType.Size = new System.Drawing.Size(396, 21);
            this.cbElementType.TabIndex = 8;
            this.cbElementType.SelectedIndexChanged += new System.EventHandler(this.cbElementType_SelectedIndexChanged);
            // 
            // lbElementType
            // 
            this.lbElementType.AutoSize = true;
            this.lbElementType.Location = new System.Drawing.Point(12, 80);
            this.lbElementType.Name = "lbElementType";
            this.lbElementType.Size = new System.Drawing.Size(78, 13);
            this.lbElementType.TabIndex = 9;
            this.lbElementType.Text = "Тип элемента";
            // 
            // NewElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 190);
            this.Controls.Add(this.lbElementType);
            this.Controls.Add(this.cbElementType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый элемент";
            this.Shown += new System.EventHandler(this.NewElementForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbElementType;
        private System.Windows.Forms.Label lbElementType;
    }
}