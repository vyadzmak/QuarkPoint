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
            this.tpColumns = new System.Windows.Forms.TabPage();
            this.tpHeaders = new System.Windows.Forms.TabPage();
            this.tpFooters = new System.Windows.Forms.TabPage();
            this.tpRows = new System.Windows.Forms.TabPage();
            this.tpView = new System.Windows.Forms.TabPage();
            this.tcTableProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTableProperties
            // 
            this.tcTableProperties.Controls.Add(this.tpGeneral);
            this.tcTableProperties.Controls.Add(this.tpColumns);
            this.tcTableProperties.Controls.Add(this.tpHeaders);
            this.tcTableProperties.Controls.Add(this.tpFooters);
            this.tcTableProperties.Controls.Add(this.tpRows);
            this.tcTableProperties.Controls.Add(this.tpView);
            this.tcTableProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTableProperties.Location = new System.Drawing.Point(0, 0);
            this.tcTableProperties.Name = "tcTableProperties";
            this.tcTableProperties.SelectedIndex = 0;
            this.tcTableProperties.Size = new System.Drawing.Size(448, 335);
            this.tcTableProperties.TabIndex = 1;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(440, 309);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Общие";
            // 
            // tpColumns
            // 
            this.tpColumns.BackColor = System.Drawing.SystemColors.Control;
            this.tpColumns.Location = new System.Drawing.Point(4, 22);
            this.tpColumns.Name = "tpColumns";
            this.tpColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tpColumns.Size = new System.Drawing.Size(440, 309);
            this.tpColumns.TabIndex = 1;
            this.tpColumns.Text = "Колонки";
            // 
            // tpHeaders
            // 
            this.tpHeaders.BackColor = System.Drawing.SystemColors.Control;
            this.tpHeaders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpHeaders.Name = "tpHeaders";
            this.tpHeaders.Size = new System.Drawing.Size(440, 309);
            this.tpHeaders.TabIndex = 2;
            this.tpHeaders.Text = "Заголовки";
            // 
            // tpFooters
            // 
            this.tpFooters.BackColor = System.Drawing.SystemColors.Control;
            this.tpFooters.Location = new System.Drawing.Point(4, 22);
            this.tpFooters.Name = "tpFooters";
            this.tpFooters.Size = new System.Drawing.Size(440, 309);
            this.tpFooters.TabIndex = 3;
            this.tpFooters.Text = "Футеры";
            // 
            // tpRows
            // 
            this.tpRows.BackColor = System.Drawing.SystemColors.Control;
            this.tpRows.Location = new System.Drawing.Point(4, 22);
            this.tpRows.Name = "tpRows";
            this.tpRows.Size = new System.Drawing.Size(440, 309);
            this.tpRows.TabIndex = 4;
            this.tpRows.Text = "Строки";
            // 
            // tpView
            // 
            this.tpView.BackColor = System.Drawing.SystemColors.Control;
            this.tpView.Location = new System.Drawing.Point(4, 22);
            this.tpView.Name = "tpView";
            this.tpView.Size = new System.Drawing.Size(440, 309);
            this.tpView.TabIndex = 5;
            this.tpView.Text = "Представление";
            // 
            // TablePropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcTableProperties);
            this.Name = "TablePropertiesControl";
            this.Size = new System.Drawing.Size(448, 335);
            this.tcTableProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcTableProperties;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpColumns;
        private System.Windows.Forms.TabPage tpHeaders;
        private System.Windows.Forms.TabPage tpFooters;
        private System.Windows.Forms.TabPage tpRows;
        private System.Windows.Forms.TabPage tpView;
    }
}
