namespace QuarkPoint.Tester.UI.Controls
{
    partial class TableDataByArrayControl
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
            this.nColumnCount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbColumnCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nColumnCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nColumnCount
            // 
            this.nColumnCount.Location = new System.Drawing.Point(3, 26);
            this.nColumnCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nColumnCount.Name = "nColumnCount";
            this.nColumnCount.Size = new System.Drawing.Size(285, 20);
            this.nColumnCount.TabIndex = 0;
            this.nColumnCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(213, 52);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbColumnCount
            // 
            this.lbColumnCount.AutoSize = true;
            this.lbColumnCount.Location = new System.Drawing.Point(3, 10);
            this.lbColumnCount.Name = "lbColumnCount";
            this.lbColumnCount.Size = new System.Drawing.Size(114, 13);
            this.lbColumnCount.TabIndex = 6;
            this.lbColumnCount.Text = "Размерность группы";
            // 
            // TableDataByArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbColumnCount);
            this.Controls.Add(this.nColumnCount);
            this.Name = "TableDataByArray";
            this.Size = new System.Drawing.Size(309, 99);
            ((System.ComponentModel.ISupportInitialize)(this.nColumnCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nColumnCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbColumnCount;
    }
}
