using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarkPoint.Tester.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// select paths
        /// </summary>
        /// <param name="box"></param>
        private void SelectPath(TextBox box)
        {
            try
            {
                if (fbDialog.ShowDialog() == DialogResult.OK)
                {
                    box.Text = fbDialog.SelectedPath;
                }
            }
            catch (Exception e)
            {
                
            }
        }

        /// <summary>
        /// init settings in form show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                fbDialog.SelectedPath = Program.MainForm.settings.StartupPath;
                txtTemplatePath.DataBindings.Add("Text", Program.MainForm.settings, "TemplateFolder", false,
                    DataSourceUpdateMode.OnPropertyChanged);

                txtTempPath.DataBindings.Add("Text", Program.MainForm.settings, "TempFolder", false,
                    DataSourceUpdateMode.OnPropertyChanged);

                txtReportPath.DataBindings.Add("Text", Program.MainForm.settings, "ReportFolder", false,
                    DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception exception)
            {
                
            }
        }

        /// <summary>
        /// Cancel click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// OK click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Program.MainForm.settings.Save();
                this.Close();
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// change templates path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectTemplatePath_Click(object sender, EventArgs e)
        {
            try
            {
                SelectPath(txtTemplatePath);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// change temp path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectTempPath_Click(object sender, EventArgs e)
        {
            try
            {
                SelectPath(txtTempPath);
            }
            catch (Exception exception)
            {
            }
        }

        /// <summary>
        /// change reports path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectReportPath_Click(object sender, EventArgs e)
        {
            try
            {
                SelectPath(txtReportPath);
            }
            catch (Exception exception)
            {
            }
        }
    }
}
