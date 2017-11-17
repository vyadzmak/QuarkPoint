namespace QuarkPoint.Tester.UI.Controls
{
    partial class ManualEnterTablePropertiesControl
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
            this.numColumnsCount = new System.Windows.Forms.NumericUpDown();
            this.lblColumnsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numColumnsCount
            // 
            this.numColumnsCount.Location = new System.Drawing.Point(6, 36);
            this.numColumnsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumnsCount.Name = "numColumnsCount";
            this.numColumnsCount.Size = new System.Drawing.Size(426, 20);
            this.numColumnsCount.TabIndex = 0;
            this.numColumnsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumnsCount.ValueChanged += new System.EventHandler(this.numColumnsCount_ValueChanged);
            // 
            // lblColumnsCount
            // 
            this.lblColumnsCount.AutoSize = true;
            this.lblColumnsCount.Location = new System.Drawing.Point(6, 20);
            this.lblColumnsCount.Name = "lblColumnsCount";
            this.lblColumnsCount.Size = new System.Drawing.Size(116, 13);
            this.lblColumnsCount.TabIndex = 1;
            this.lblColumnsCount.Text = "Количество столбцов";
            // 
            // ManualEnterTablePropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblColumnsCount);
            this.Controls.Add(this.numColumnsCount);
            this.Name = "ManualEnterTablePropertiesControl";
            this.Size = new System.Drawing.Size(432, 74);
            ((System.ComponentModel.ISupportInitialize)(this.numColumnsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numColumnsCount;
        private System.Windows.Forms.Label lblColumnsCount;
    }
}
