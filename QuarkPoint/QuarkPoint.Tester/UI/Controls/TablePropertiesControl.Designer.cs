namespace QuarkPoint.Tester.UI.Controls
{
    partial class TablePropertiesControl
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
            this.tcTableProperties = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbSelectType = new System.Windows.Forms.GroupBox();
            this.rbAutoWithFormat = new System.Windows.Forms.RadioButton();
            this.rbAutoWithoutFormat = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.chbUseFooters = new System.Windows.Forms.CheckBox();
            this.chbUseHeaders = new System.Windows.Forms.CheckBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.tpHeaders = new System.Windows.Forms.TabPage();
            this.tpFooters = new System.Windows.Forms.TabPage();
            this.tpBody = new System.Windows.Forms.TabPage();
            this.tcTableProperties.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gbConfirm.SuspendLayout();
            this.gbSelectType.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTableProperties
            // 
            this.tcTableProperties.Controls.Add(this.tpGeneral);
            this.tcTableProperties.Controls.Add(this.tpHeaders);
            this.tcTableProperties.Controls.Add(this.tpFooters);
            this.tcTableProperties.Controls.Add(this.tpBody);
            this.tcTableProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTableProperties.Location = new System.Drawing.Point(0, 0);
            this.tcTableProperties.Name = "tcTableProperties";
            this.tcTableProperties.SelectedIndex = 0;
            this.tcTableProperties.Size = new System.Drawing.Size(550, 378);
            this.tcTableProperties.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tpGeneral.Controls.Add(this.gbDetails);
            this.tpGeneral.Controls.Add(this.gbConfirm);
            this.tpGeneral.Controls.Add(this.gbSelectType);
            this.tpGeneral.Controls.Add(this.gbGeneral);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(542, 352);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Данные";
            // 
            // gbDetails
            // 
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(3, 195);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.gbDetails.Size = new System.Drawing.Size(536, 117);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Подробнее";
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.btnOk);
            this.gbConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConfirm.Location = new System.Drawing.Point(3, 312);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(536, 37);
            this.gbConfirm.TabIndex = 3;
            this.gbConfirm.TabStop = false;
            this.gbConfirm.Text = "Подтверждение";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(458, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // gbSelectType
            // 
            this.gbSelectType.Controls.Add(this.rbAutoWithFormat);
            this.gbSelectType.Controls.Add(this.rbAutoWithoutFormat);
            this.gbSelectType.Controls.Add(this.rbManual);
            this.gbSelectType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSelectType.Location = new System.Drawing.Point(3, 106);
            this.gbSelectType.Name = "gbSelectType";
            this.gbSelectType.Size = new System.Drawing.Size(536, 89);
            this.gbSelectType.TabIndex = 0;
            this.gbSelectType.TabStop = false;
            this.gbSelectType.Text = "Тип данных";
            // 
            // rbAutoWithFormat
            // 
            this.rbAutoWithFormat.AutoSize = true;
            this.rbAutoWithFormat.Location = new System.Drawing.Point(9, 65);
            this.rbAutoWithFormat.Name = "rbAutoWithFormat";
            this.rbAutoWithFormat.Size = new System.Drawing.Size(365, 17);
            this.rbAutoWithFormat.TabIndex = 2;
            this.rbAutoWithFormat.Text = "Авто с форматом (Сложные таблицы Типа ОПиУ, Баланса, ОДДС)";
            this.rbAutoWithFormat.UseVisualStyleBackColor = true;
            this.rbAutoWithFormat.CheckedChanged += new System.EventHandler(this.rbAutoWithFormat_CheckedChanged);
            // 
            // rbAutoWithoutFormat
            // 
            this.rbAutoWithoutFormat.AutoSize = true;
            this.rbAutoWithoutFormat.Location = new System.Drawing.Point(9, 42);
            this.rbAutoWithoutFormat.Name = "rbAutoWithoutFormat";
            this.rbAutoWithoutFormat.Size = new System.Drawing.Size(528, 17);
            this.rbAutoWithoutFormat.TabIndex = 1;
            this.rbAutoWithoutFormat.Text = "Авто без формата (Простые таблицы из источника данных, то есть перечисляемые с ша" +
    "пкой/без)";
            this.rbAutoWithoutFormat.UseVisualStyleBackColor = true;
            this.rbAutoWithoutFormat.CheckedChanged += new System.EventHandler(this.rbAutoWithoutFormat_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(9, 19);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(332, 17);
            this.rbManual.TabIndex = 0;
            this.rbManual.Text = "Ручной ввод (таблицы, в которые вручную вводятся данные)";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.chbUseFooters);
            this.gbGeneral.Controls.Add(this.chbUseHeaders);
            this.gbGeneral.Controls.Add(this.txtTableName);
            this.gbGeneral.Controls.Add(this.lblTableName);
            this.gbGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(536, 103);
            this.gbGeneral.TabIndex = 1;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Общие";
            // 
            // chbUseFooters
            // 
            this.chbUseFooters.AutoSize = true;
            this.chbUseFooters.Location = new System.Drawing.Point(9, 80);
            this.chbUseFooters.Name = "chbUseFooters";
            this.chbUseFooters.Size = new System.Drawing.Size(140, 17);
            this.chbUseFooters.TabIndex = 3;
            this.chbUseFooters.Text = "Использовать футеры";
            this.chbUseFooters.UseVisualStyleBackColor = true;
            this.chbUseFooters.CheckedChanged += new System.EventHandler(this.chbUseFooters_CheckedChanged);
            // 
            // chbUseHeaders
            // 
            this.chbUseHeaders.AutoSize = true;
            this.chbUseHeaders.Location = new System.Drawing.Point(9, 58);
            this.chbUseHeaders.Name = "chbUseHeaders";
            this.chbUseHeaders.Size = new System.Drawing.Size(155, 17);
            this.chbUseHeaders.TabIndex = 2;
            this.chbUseHeaders.Text = "Использовать заголовки";
            this.chbUseHeaders.UseVisualStyleBackColor = true;
            this.chbUseHeaders.CheckedChanged += new System.EventHandler(this.chbUseHeaders_CheckedChanged);
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableName.Location = new System.Drawing.Point(9, 32);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(524, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(6, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(75, 13);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Имя таблицы";
            // 
            // tpHeaders
            // 
            this.tpHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpHeaders.Name = "tpHeaders";
            this.tpHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeaders.Size = new System.Drawing.Size(542, 352);
            this.tpHeaders.TabIndex = 1;
            this.tpHeaders.Text = "Заголовки";
            this.tpHeaders.UseVisualStyleBackColor = true;
            // 
            // tpFooters
            // 
            this.tpFooters.Location = new System.Drawing.Point(4, 22);
            this.tpFooters.Name = "tpFooters";
            this.tpFooters.Size = new System.Drawing.Size(542, 352);
            this.tpFooters.TabIndex = 2;
            this.tpFooters.Text = "Футеры";
            this.tpFooters.UseVisualStyleBackColor = true;
            // 
            // tpBody
            // 
            this.tpBody.Location = new System.Drawing.Point(4, 22);
            this.tpBody.Name = "tpBody";
            this.tpBody.Size = new System.Drawing.Size(542, 352);
            this.tpBody.TabIndex = 3;
            this.tpBody.Text = "Контент";
            this.tpBody.UseVisualStyleBackColor = true;
            // 
            // TablePropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcTableProperties);
            this.Name = "TablePropertiesControl";
            this.Size = new System.Drawing.Size(550, 378);
            this.tcTableProperties.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.gbConfirm.ResumeLayout(false);
            this.gbSelectType.ResumeLayout(false);
            this.gbSelectType.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTableProperties;
        private System.Windows.Forms.TabPage tpHeaders;
        private System.Windows.Forms.TabPage tpFooters;
        private System.Windows.Forms.TabPage tpBody;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.GroupBox gbSelectType;
        private System.Windows.Forms.RadioButton rbAutoWithFormat;
        private System.Windows.Forms.RadioButton rbAutoWithoutFormat;
        private System.Windows.Forms.RadioButton rbManual;
        public System.Windows.Forms.TabPage tpGeneral;
        public System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox gbConfirm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chbUseFooters;
        private System.Windows.Forms.CheckBox chbUseHeaders;
    }
}
