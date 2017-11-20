namespace QuarkPoint.Tester.UI.Controls
{
    partial class AutoBindingWithoutFormattingTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoBindingWithoutFormattingTableControl));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceData = new System.Windows.Forms.TextBox();
            this.btnFieldBindings = new System.Windows.Forms.Button();
            this.chlbFields = new System.Windows.Forms.CheckedListBox();
            this.btnUpElement = new System.Windows.Forms.Button();
            this.btnDownElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Источник данных";
            // 
            // txtSourceData
            // 
            this.txtSourceData.Location = new System.Drawing.Point(3, 21);
            this.txtSourceData.Name = "txtSourceData";
            this.txtSourceData.Size = new System.Drawing.Size(278, 20);
            this.txtSourceData.TabIndex = 5;
            // 
            // btnFieldBindings
            // 
            this.btnFieldBindings.Location = new System.Drawing.Point(287, 19);
            this.btnFieldBindings.Name = "btnFieldBindings";
            this.btnFieldBindings.Size = new System.Drawing.Size(139, 23);
            this.btnFieldBindings.TabIndex = 6;
            this.btnFieldBindings.Text = "Получить поля";
            this.btnFieldBindings.UseVisualStyleBackColor = true;
            this.btnFieldBindings.Click += new System.EventHandler(this.btnFieldBindings_Click);
            // 
            // chlbFields
            // 
            this.chlbFields.FormattingEnabled = true;
            this.chlbFields.Location = new System.Drawing.Point(3, 57);
            this.chlbFields.Name = "chlbFields";
            this.chlbFields.Size = new System.Drawing.Size(423, 169);
            this.chlbFields.TabIndex = 7;
            this.chlbFields.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlbFields_ItemCheck);
            this.chlbFields.SelectedIndexChanged += new System.EventHandler(this.chlbFields_SelectedIndexChanged);
            this.chlbFields.SelectedValueChanged += new System.EventHandler(this.chlbFields_SelectedValueChanged);
            // 
            // btnUpElement
            // 
            this.btnUpElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpElement.Image = ((System.Drawing.Image)(resources.GetObject("btnUpElement.Image")));
            this.btnUpElement.Location = new System.Drawing.Point(432, 110);
            this.btnUpElement.Name = "btnUpElement";
            this.btnUpElement.Size = new System.Drawing.Size(23, 23);
            this.btnUpElement.TabIndex = 8;
            this.btnUpElement.UseVisualStyleBackColor = true;
            this.btnUpElement.Click += new System.EventHandler(this.btnUpElement_Click);
            // 
            // btnDownElement
            // 
            this.btnDownElement.Image = ((System.Drawing.Image)(resources.GetObject("btnDownElement.Image")));
            this.btnDownElement.Location = new System.Drawing.Point(432, 139);
            this.btnDownElement.Name = "btnDownElement";
            this.btnDownElement.Size = new System.Drawing.Size(23, 23);
            this.btnDownElement.TabIndex = 9;
            this.btnDownElement.UseVisualStyleBackColor = true;
            this.btnDownElement.Click += new System.EventHandler(this.btnDownElement_Click);
            // 
            // AutoBindingWithoutFormattingTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDownElement);
            this.Controls.Add(this.btnUpElement);
            this.Controls.Add(this.chlbFields);
            this.Controls.Add(this.btnFieldBindings);
            this.Controls.Add(this.txtSourceData);
            this.Controls.Add(this.label1);
            this.Name = "AutoBindingWithoutFormattingTableControl";
            this.Size = new System.Drawing.Size(467, 238);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceData;
        private System.Windows.Forms.Button btnFieldBindings;
        private System.Windows.Forms.CheckedListBox chlbFields;
        private System.Windows.Forms.Button btnUpElement;
        private System.Windows.Forms.Button btnDownElement;
    }
}
