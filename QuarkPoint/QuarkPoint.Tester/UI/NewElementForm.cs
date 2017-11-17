using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Exporter.Models.TemplateModels.TableModels;
using QuarkPoint.Tester.Helpers.GUI;

namespace QuarkPoint.Tester.UI
{
    public partial class NewElementForm : Form
    {
        public NewElementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewElementForm_Shown(object sender, EventArgs e)
        {
            try
            {
                cbElementType.DataSource = Enum.GetValues(typeof(ElementType));
                cbElementType.SelectedItem = ElementType.Текст;
            }
            catch (Exception exception)
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exception)
            {
                
            }
        }

        /// <summary>
        /// event btn OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string elementName = txtElementName.Text;

                if (!string.IsNullOrEmpty(elementName))
                {
                    var template = Program.MainForm.CurrentTemplate;

                    ElementType status;
                    Enum.TryParse<ElementType>(cbElementType.SelectedValue.ToString(), out status);
                    TemplateElement element = new TemplateElement();
                    element.Title = elementName;
                    switch (status)
                    {
                            case ElementType.Текст:
                                element.ElementType = ElementType.Текст;
                                element.Paragraph = new TemplateParagraph();
                            break;

                        case ElementType.Таблица:
                            element.ElementType = ElementType.Таблица;
                            element.Table = new TableModel();

                            break;

                        case ElementType.Перенос:
                            element.ElementType = ElementType.Перенос;
                            element.NewLine = new TemplateNewLine();
                            break;

                    }
                    template.Changed = true;
                    this.Close();

                    template.Elements.Add(element);
                    GuiListHelper.AddNewElement(element);
                    
                }
                else
                {
                    MessageBox.Show("Имя должно быть заполнено", "Имя элемента должно быть заполнено",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void cbElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbElementType.Text == "Перенос")
                {
                    txtElementName.Text = "Перенос";
                    txtElementName.Enabled = false;
                }
                else
                {
                    txtElementName.Enabled = true;
                }
                
            }
            catch (Exception exception)
            {

            }
        }
    }
}
