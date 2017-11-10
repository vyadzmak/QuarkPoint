using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.GUI;

namespace QuarkPoint.Tester.UI
{
    public partial class NewTemplateForm : Form
    {
        public NewTemplateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTemplateName.Text))
                {

                    Program.MainForm.CurrentTemplate = new TemplateModel();
                    Program.MainForm.CurrentTemplate.Name = txtTemplateName.Text;
                    string templateName = txtTemplateName.Text + ".json";
                    string templatePath = Path.Combine(Program.MainForm.settings.TemplateFolder, templateName);
                    bool isSaved = Program.MainForm.CurrentTemplate.Save(templatePath);

                    if (!isSaved)
                    {
                        MessageBox.Show("Ошибка создания шаблона", "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Program.MainForm.CurrentTemplate = null;
                        txtTemplateName.Text = "";
                        
                    }
                    else
                    {
                        
                        GuiEventListeners.UnlockControlsWithNewTemplate();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Имя должно быть заполнено", "Имя шаблона должно быть заполнено",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка создания шаблона. "+exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
