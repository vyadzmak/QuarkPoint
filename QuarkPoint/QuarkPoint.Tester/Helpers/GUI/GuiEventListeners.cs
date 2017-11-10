using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Tester.Helpers.GUI
{
    public static class GuiEventListeners
    {
        /// <summary>
        /// unlock elements with create new template
        /// </summary>
        public static void UnlockControlsWithNewTemplate()
        {
            try
            {
                var form = Program.MainForm;
                form.tsbDownElement.Enabled = true;
                form.tsbUpElement.Enabled = true;
                form.tsbAddNewElement.Enabled = true;
                form.tsbRemoveElement.Enabled = true;
                form.tsmSaveTemplate.Enabled = true;
                form.tsmGenerateSelectedElement.Enabled = true;
                form.tsmGenerateFullTemplate.Enabled = true;
                form.ts.Enabled = true;
                GuiListHelper.SelectFirstItem();
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// update form text
        /// </summary>
        public static void UpdateFormTitle()
        {
            try
            {
                Program.MainForm.Text = Program.MainForm.settings.AppName + " - " + Program.MainForm.CurrentTemplate.Name;
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// update form text
        /// </summary>
        public static void UpdateTemplateChangedFormTitle()
        {
            try
            {
                Program.MainForm.Text = Program.MainForm.settings.AppName + " - " + Program.MainForm.CurrentTemplate.Name+" *";
            }
            catch (Exception e)
            {
            }
        }
    }
}
