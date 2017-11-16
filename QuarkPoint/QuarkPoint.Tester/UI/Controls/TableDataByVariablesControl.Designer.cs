namespace QuarkPoint.Tester.UI.Controls
{
    partial class TableDataByVariablesControl
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
            this.lbGroupCount = new System.Windows.Forms.Label();
            this.nGroupCount = new System.Windows.Forms.NumericUpDown();
            this.nSizeGroup = new System.Windows.Forms.NumericUpDown();
            this.lbSizeGroup = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nGroupCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSizeGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGroupCount
            // 
            this.lbGroupCount.AutoSize = true;
            this.lbGroupCount.Location = new System.Drawing.Point(3, 9);
            this.lbGroupCount.Name = "lbGroupCount";
            this.lbGroupCount.Size = new System.Drawing.Size(97, 13);
            this.lbGroupCount.TabIndex = 0;
            this.lbGroupCount.Text = "Количество групп";
            // 
            // nGroupCount
            // 
            this.nGroupCount.Location = new System.Drawing.Point(123, 7);
            this.nGroupCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nGroupCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nGroupCount.Name = "nGroupCount";
            this.nGroupCount.Size = new System.Drawing.Size(120, 20);
            this.nGroupCount.TabIndex = 1;
            this.nGroupCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nSizeGroup
            // 
            this.nSizeGroup.Location = new System.Drawing.Point(123, 38);
            this.nSizeGroup.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nSizeGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSizeGroup.Name = "nSizeGroup";
            this.nSizeGroup.Size = new System.Drawing.Size(120, 20);
            this.nSizeGroup.TabIndex = 3;
            this.nSizeGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSizeGroup
            // 
            this.lbSizeGroup.AutoSize = true;
            this.lbSizeGroup.Location = new System.Drawing.Point(3, 40);
            this.lbSizeGroup.Name = "lbSizeGroup";
            this.lbSizeGroup.Size = new System.Drawing.Size(114, 13);
            this.lbSizeGroup.TabIndex = 2;
            this.lbSizeGroup.Text = "Размерность группы";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(168, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TableDataByVariablesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nSizeGroup);
            this.Controls.Add(this.lbSizeGroup);
            this.Controls.Add(this.nGroupCount);
            this.Controls.Add(this.lbGroupCount);
            this.Name = "TableDataByVariablesControl";
            this.Size = new System.Drawing.Size(254, 117);
            ((System.ComponentModel.ISupportInitialize)(this.nGroupCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSizeGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGroupCount;
        private System.Windows.Forms.NumericUpDown nGroupCount;
        private System.Windows.Forms.NumericUpDown nSizeGroup;
        private System.Windows.Forms.Label lbSizeGroup;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
