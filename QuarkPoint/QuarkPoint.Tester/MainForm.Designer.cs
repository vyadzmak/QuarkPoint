namespace QuarkPoint.Tester
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbTemplateElements = new System.Windows.Forms.ListBox();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tabProcessing = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tsmOpenTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbDownElement = new System.Windows.Forms.ToolStripButton();
            this.tsbUpElement = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveElement = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNewElement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmNewTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGenerateSelectedElement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGenerateFullTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportToDb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ms.SuspendLayout();
            this.tabProcessing.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbTemplateElements);
            this.splitContainer1.Panel1.Controls.Add(this.ts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabProcessing);
            this.splitContainer1.Size = new System.Drawing.Size(749, 302);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbTemplateElements
            // 
            this.lbTemplateElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemplateElements.FormattingEnabled = true;
            this.lbTemplateElements.Location = new System.Drawing.Point(0, 25);
            this.lbTemplateElements.Name = "lbTemplateElements";
            this.lbTemplateElements.Size = new System.Drawing.Size(249, 277);
            this.lbTemplateElements.TabIndex = 0;
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmTest});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(749, 24);
            this.ms.TabIndex = 1;
            this.ms.Text = "Меню";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewTemplate,
            this.tsmOpenTemplate,
            this.tsmSaveTemplate,
            this.tsmExportToDb,
            this.tsmSettings,
            this.toolStripMenuItem1,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(48, 20);
            this.tsmFile.Text = "Файл";
            // 
            // tsmTest
            // 
            this.tsmTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGenerateSelectedElement,
            this.tsmGenerateFullTemplate});
            this.tsmTest.Name = "tsmTest";
            this.tsmTest.Size = new System.Drawing.Size(43, 20);
            this.tsmTest.Text = "Тест";
            // 
            // tabProcessing
            // 
            this.tabProcessing.Controls.Add(this.tabPage1);
            this.tabProcessing.Controls.Add(this.tabPage2);
            this.tabProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProcessing.Location = new System.Drawing.Point(0, 0);
            this.tabProcessing.Name = "tabProcessing";
            this.tabProcessing.SelectedIndex = 0;
            this.tabProcessing.Size = new System.Drawing.Size(496, 302);
            this.tabProcessing.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tsmOpenTemplate
            // 
            this.tsmOpenTemplate.Name = "tsmOpenTemplate";
            this.tsmOpenTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmOpenTemplate.Size = new System.Drawing.Size(203, 22);
            this.tsmOpenTemplate.Text = "Открыть";
            // 
            // tsmSaveTemplate
            // 
            this.tsmSaveTemplate.Name = "tsmSaveTemplate";
            this.tsmSaveTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmSaveTemplate.Size = new System.Drawing.Size(203, 22);
            this.tsmSaveTemplate.Text = "Сохранить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmExit.Size = new System.Drawing.Size(203, 22);
            this.tsmExit.Text = "Выход";
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNewElement,
            this.tsbRemoveElement,
            this.toolStripSeparator1,
            this.tsbDownElement,
            this.tsbUpElement});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(249, 25);
            this.ts.TabIndex = 1;
            this.ts.Text = "toolStrip1";
            // 
            // tsbDownElement
            // 
            this.tsbDownElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDownElement.Image = ((System.Drawing.Image)(resources.GetObject("tsbDownElement.Image")));
            this.tsbDownElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDownElement.Name = "tsbDownElement";
            this.tsbDownElement.Size = new System.Drawing.Size(23, 22);
            this.tsbDownElement.Text = "Вниз по списку";
            // 
            // tsbUpElement
            // 
            this.tsbUpElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpElement.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpElement.Image")));
            this.tsbUpElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpElement.Name = "tsbUpElement";
            this.tsbUpElement.Size = new System.Drawing.Size(23, 22);
            this.tsbUpElement.Text = "Вверх по списку";
            // 
            // tsbRemoveElement
            // 
            this.tsbRemoveElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveElement.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveElement.Image")));
            this.tsbRemoveElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveElement.Name = "tsbRemoveElement";
            this.tsbRemoveElement.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveElement.Text = "Удалить выбранный элемент";
            // 
            // tsbAddNewElement
            // 
            this.tsbAddNewElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNewElement.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNewElement.Image")));
            this.tsbAddNewElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewElement.Name = "tsbAddNewElement";
            this.tsbAddNewElement.Size = new System.Drawing.Size(23, 22);
            this.tsbAddNewElement.Text = "Добавить новый элемент";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmNewTemplate
            // 
            this.tsmNewTemplate.Name = "tsmNewTemplate";
            this.tsmNewTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmNewTemplate.Size = new System.Drawing.Size(203, 22);
            this.tsmNewTemplate.Text = "Новый шаблон";
            // 
            // tsmGenerateSelectedElement
            // 
            this.tsmGenerateSelectedElement.Name = "tsmGenerateSelectedElement";
            this.tsmGenerateSelectedElement.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmGenerateSelectedElement.Size = new System.Drawing.Size(315, 22);
            this.tsmGenerateSelectedElement.Text = "Сгенерировать выбранный элемент";
            // 
            // tsmGenerateFullTemplate
            // 
            this.tsmGenerateFullTemplate.Name = "tsmGenerateFullTemplate";
            this.tsmGenerateFullTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.tsmGenerateFullTemplate.Size = new System.Drawing.Size(315, 22);
            this.tsmGenerateFullTemplate.Text = "Сгенерировать весь шаблон";
            // 
            // tsmExportToDb
            // 
            this.tsmExportToDb.Name = "tsmExportToDb";
            this.tsmExportToDb.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExportToDb.Size = new System.Drawing.Size(203, 22);
            this.tsmExportToDb.Text = "Экспорт в БД";
            this.tsmExportToDb.ToolTipText = "Экспортировать шаблон в базу данных";
            // 
            // tsmSettings
            // 
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(203, 22);
            this.tsmSettings.Text = "Настройки";
            this.tsmSettings.ToolTipText = "Открыть окно системных настроек";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 326);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarkPoint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.tabProcessing.ResumeLayout(false);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox lbTemplateElements;
        private System.Windows.Forms.TabControl tabProcessing;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmTest;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbAddNewElement;
        public System.Windows.Forms.ToolStripButton tsbRemoveElement;
        public System.Windows.Forms.ToolStripButton tsbDownElement;
        public System.Windows.Forms.ToolStripButton tsbUpElement;
        public System.Windows.Forms.MenuStrip ms;
        public System.Windows.Forms.ToolStripMenuItem tsmOpenTemplate;
        public System.Windows.Forms.ToolStripMenuItem tsmSaveTemplate;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem tsmExit;
        public System.Windows.Forms.ToolStripMenuItem tsmNewTemplate;
        public System.Windows.Forms.ToolStripMenuItem tsmGenerateSelectedElement;
        public System.Windows.Forms.ToolStripMenuItem tsmGenerateFullTemplate;
        public System.Windows.Forms.ToolStripMenuItem tsmExportToDb;
        public System.Windows.Forms.ToolStripMenuItem tsmSettings;
    }
}

