using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkPoint.Tester.UI;

namespace QuarkPoint.Tester.Helpers.GUI
{
    /// <summary>
    /// gui helper
    /// </summary>
    public static class GuiHelper
    {
        #region menu events
        /// <summary>
        /// exit menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmExit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("OK");
            }
            catch (Exception exception)
            {
                Program.log.Error(exception);
            }
        }

        /// <summary>
        /// new template menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmNewTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                NewTemplateForm form = new NewTemplateForm();
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// open template menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmOpenTemplate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// generate full template menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmGenerateFullTemplate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// generate selected element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmGenerateSelectedElement_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// settings menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmSettings_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsForm form = new SettingsForm();
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// export to db menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmExportToDb_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }

        }

        /// <summary>
        /// save template menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsmSaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }
        #endregion


        #region toolbar events
        /// <summary>
        /// up element toolbar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsbUpElement_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// down element toolbar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private static void TsbDownElement_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// remove element toolbar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsbRemoveElement_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

        /// <summary>
        /// add element toolbar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TsbAddNewElement_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }
        #endregion
        /// <summary>
        /// init all events for controls on the form
        /// </summary>
        public static void InitControlEvents()
        {
            try
            {
                var form = Program.MainForm;
                //menu
                form.tsmExit.Click += TsmExit_Click;
                form.tsmNewTemplate.Click += TsmNewTemplate_Click;
                form.tsmOpenTemplate.Click += TsmOpenTemplate_Click;
                form.tsmSaveTemplate.Click += TsmSaveTemplate_Click;
                form.tsmExportToDb.Click += TsmExportToDb_Click;
                form.tsmSettings.Click += TsmSettings_Click;
                form.tsmGenerateSelectedElement.Click += TsmGenerateSelectedElement_Click;
                form.tsmGenerateFullTemplate.Click += TsmGenerateFullTemplate_Click;

                //toolbar
                form.tsbAddNewElement.Click += TsbAddNewElement_Click;
                form.tsbRemoveElement.Click += TsbRemoveElement_Click;
                form.tsbDownElement.Click += TsbDownElement_Click;
                form.tsbUpElement.Click += TsbUpElement_Click;
            }
            catch (Exception exception)
            {
                Program.log.Error(exception);

            }
        }

    }
}
