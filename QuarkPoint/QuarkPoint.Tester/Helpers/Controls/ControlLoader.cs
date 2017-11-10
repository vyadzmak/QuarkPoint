using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.UI.Controls;

namespace QuarkPoint.Tester.Helpers.Controls
{
    public static class ControlLoader
    {
        /// <summary>
        /// load control to container
        /// </summary>
        /// <param name="control"></param>
        private static void LoadControl(Control control)
        {
            try
            {
                var container = Program.MainForm.pContainer;
                container.Controls.Clear();
                container.Controls.Add(control);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void LoadControlByElement()
        {
            try
            {
                TemplateElement element = Program.MainForm.CurrentElement;

                if (element==null) return;

                switch (element.ElementType)
                {
                        case ElementType.Текст:
                        ParagraphPropertiesControl pControl = new ParagraphPropertiesControl();
                        LoadControl(pControl);
                        break;

                    case ElementType.Таблица:
                        TablePropertiesControl tControl = new TablePropertiesControl();
                        LoadControl(tControl);
                        break;
                }


            }
            catch (Exception e)
            {
            }
        }
    }
}
