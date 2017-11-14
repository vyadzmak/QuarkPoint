namespace QuarkPoint.Tester.UI.Controls
{
    partial class ParagraphPropertiesControl
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
            this.tcParagraphProperties = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tpStyles = new System.Windows.Forms.TabPage();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lblForegroundColor = new System.Windows.Forms.Label();
            this.btnForegroundColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nFontSize = new System.Windows.Forms.NumericUpDown();
            this.cbTextAlign = new System.Windows.Forms.ComboBox();
            this.lblTextAlign = new System.Windows.Forms.Label();
            this.cbFontWeight = new System.Windows.Forms.ComboBox();
            this.lblFontWeight = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.tcParagraphProperties.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpStyles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tcParagraphProperties
            // 
            this.tcParagraphProperties.Controls.Add(this.tpGeneral);
            this.tcParagraphProperties.Controls.Add(this.tpStyles);
            this.tcParagraphProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcParagraphProperties.Location = new System.Drawing.Point(0, 0);
            this.tcParagraphProperties.Name = "tcParagraphProperties";
            this.tcParagraphProperties.SelectedIndex = 0;
            this.tcParagraphProperties.Size = new System.Drawing.Size(524, 368);
            this.tcParagraphProperties.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tpGeneral.Controls.Add(this.label3);
            this.tpGeneral.Controls.Add(this.rtbText);
            this.tpGeneral.Controls.Add(this.txtElementName);
            this.tpGeneral.Controls.Add(this.lblName);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(516, 342);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Общие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текст и схема";
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbText.Location = new System.Drawing.Point(11, 79);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(499, 257);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // txtElementName
            // 
            this.txtElementName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElementName.Location = new System.Drawing.Point(11, 24);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(499, 20);
            this.txtElementName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя элемента";
            // 
            // tpStyles
            // 
            this.tpStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tpStyles.Controls.Add(this.lblBackColor);
            this.tpStyles.Controls.Add(this.btnBackColor);
            this.tpStyles.Controls.Add(this.lblForegroundColor);
            this.tpStyles.Controls.Add(this.btnForegroundColor);
            this.tpStyles.Controls.Add(this.label2);
            this.tpStyles.Controls.Add(this.nFontSize);
            this.tpStyles.Controls.Add(this.cbTextAlign);
            this.tpStyles.Controls.Add(this.lblTextAlign);
            this.tpStyles.Controls.Add(this.cbFontWeight);
            this.tpStyles.Controls.Add(this.lblFontWeight);
            this.tpStyles.Controls.Add(this.cbFont);
            this.tpStyles.Controls.Add(this.label1);
            this.tpStyles.Location = new System.Drawing.Point(4, 22);
            this.tpStyles.Name = "tpStyles";
            this.tpStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tpStyles.Size = new System.Drawing.Size(516, 342);
            this.tpStyles.TabIndex = 1;
            this.tpStyles.Text = "Стиль";
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(221, 163);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(61, 13);
            this.lblBackColor.TabIndex = 11;
            this.lblBackColor.Text = "Цвет фона";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(222, 179);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(60, 23);
            this.btnBackColor.TabIndex = 10;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // lblForegroundColor
            // 
            this.lblForegroundColor.AutoSize = true;
            this.lblForegroundColor.Location = new System.Drawing.Point(141, 163);
            this.lblForegroundColor.Name = "lblForegroundColor";
            this.lblForegroundColor.Size = new System.Drawing.Size(74, 13);
            this.lblForegroundColor.TabIndex = 9;
            this.lblForegroundColor.Text = "Цвет шрифта";
            // 
            // btnForegroundColor
            // 
            this.btnForegroundColor.Location = new System.Drawing.Point(144, 179);
            this.btnForegroundColor.Name = "btnForegroundColor";
            this.btnForegroundColor.Size = new System.Drawing.Size(60, 23);
            this.btnForegroundColor.TabIndex = 8;
            this.btnForegroundColor.UseVisualStyleBackColor = true;
            this.btnForegroundColor.Click += new System.EventHandler(this.btnForegroundColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер шрифта";
            // 
            // nFontSize
            // 
            this.nFontSize.Location = new System.Drawing.Point(6, 179);
            this.nFontSize.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nFontSize.Name = "nFontSize";
            this.nFontSize.Size = new System.Drawing.Size(120, 20);
            this.nFontSize.TabIndex = 6;
            this.nFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cbTextAlign
            // 
            this.cbTextAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextAlign.FormattingEnabled = true;
            this.cbTextAlign.Location = new System.Drawing.Point(6, 122);
            this.cbTextAlign.Name = "cbTextAlign";
            this.cbTextAlign.Size = new System.Drawing.Size(504, 21);
            this.cbTextAlign.TabIndex = 5;
            // 
            // lblTextAlign
            // 
            this.lblTextAlign.AutoSize = true;
            this.lblTextAlign.Location = new System.Drawing.Point(6, 106);
            this.lblTextAlign.Name = "lblTextAlign";
            this.lblTextAlign.Size = new System.Drawing.Size(94, 13);
            this.lblTextAlign.TabIndex = 4;
            this.lblTextAlign.Text = "Привязка текста";
            // 
            // cbFontWeight
            // 
            this.cbFontWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontWeight.FormattingEnabled = true;
            this.cbFontWeight.Location = new System.Drawing.Point(6, 73);
            this.cbFontWeight.Name = "cbFontWeight";
            this.cbFontWeight.Size = new System.Drawing.Size(504, 21);
            this.cbFontWeight.TabIndex = 3;
            // 
            // lblFontWeight
            // 
            this.lblFontWeight.AutoSize = true;
            this.lblFontWeight.Location = new System.Drawing.Point(6, 57);
            this.lblFontWeight.Name = "lblFontWeight";
            this.lblFontWeight.Size = new System.Drawing.Size(79, 13);
            this.lblFontWeight.TabIndex = 2;
            this.lblFontWeight.Text = "Стиль шрифта";
            // 
            // cbFont
            // 
            this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(6, 26);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(504, 21);
            this.cbFont.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шрифт";
            // 
            // ParagraphPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcParagraphProperties);
            this.Name = "ParagraphPropertiesControl";
            this.Size = new System.Drawing.Size(524, 368);
            this.tcParagraphProperties.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpStyles.ResumeLayout(false);
            this.tpStyles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcParagraphProperties;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tpStyles;
        private System.Windows.Forms.ComboBox cbTextAlign;
        private System.Windows.Forms.Label lblTextAlign;
        private System.Windows.Forms.ComboBox cbFontWeight;
        private System.Windows.Forms.Label lblFontWeight;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lblForegroundColor;
        private System.Windows.Forms.Button btnForegroundColor;
    }
}
