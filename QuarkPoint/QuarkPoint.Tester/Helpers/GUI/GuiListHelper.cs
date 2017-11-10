using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Tester.Helpers.GUI
{
    public static class GuiListHelper
    {
        /// <summary>
        /// add new element to list
        /// </summary>

        public static void AddNewElement(TemplateElement element)
        {
            try
            {
                var list = Program.MainForm.lbTemplateElements;
                string text = element.Title +" ["+element.ElementType.ToString()+"]";
                list.Items.Add(text);
                int index = list.Items.Count-1;
                element.Index = index;
                SelectLastItem();
            }
            catch (Exception e)
            {
            }
        }


        /// <summary>
        /// select last item
        /// </summary>
        public static void SelectLastItem()
        {
            try
            {
                
                var list = Program.MainForm.lbTemplateElements;
                if (list.Items.Count==0) return;
                list.SelectedIndex = list.Items.Count - 1;

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// select last item
        /// </summary>
        public static void SelectFirstItem()
        {
            try
            {

                var list = Program.MainForm.lbTemplateElements;
                if (list.Items.Count == 0) return;
                list.SelectedIndex = 0;

            }
            catch (Exception e)
            {
            }
        }

        public static void LoadElements()
        {
            try
            {
                var template = Program.MainForm.CurrentTemplate;

                var list = Program.MainForm.lbTemplateElements;
                list.Items.Clear();
                foreach (var element in template.Elements)
                {


                    string text = element.Title + " [" + element.ElementType.ToString() + "]";
                    list.Items.Add(text);
                    int index = list.Items.Count - 1;
                    element.Index = index;
                }
                SelectFirstItem();
            }
            catch (Exception e)
            {
            }
        }
    }
}
