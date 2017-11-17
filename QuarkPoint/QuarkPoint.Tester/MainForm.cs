using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NLog.Targets.Wrappers;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.GUI;
using QuarkPoint.Tester.Models.Settings;
using QuarkPoint.Tester.UI.Controls;

namespace QuarkPoint.Tester
{
    public partial class MainForm : Form
    {
        #region variables
        /// <summary>
        /// settings
        /// </summary>
        public SettingModel settings = null;

        /// <summary>
        /// current template
        /// </summary>
        public Exporter.Models.TemplateModels.TemplateModel CurrentTemplate = null;

        /// <summary>
        /// selected element
        /// </summary>
        public TemplateElement CurrentElement = null;

        /// <summary>
        /// current project id
        /// </summary>
        public int CurrentProjectId = 1589;
        /// <summary>
        /// current test project
        /// </summary>
        public object CurrentProject = null;

        
        #endregion
        #region constructor

        /// <summary>
        /// constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
        }
        #endregion

        #region methods
        /// <summary>
        /// load settings from file
        /// </summary>
        public void LoadSettings()
        {
            try
            {
                using (StreamReader file = File.OpenText(Program.SettingsPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    settings = (SettingModel)serializer.Deserialize(file, typeof(SettingModel));
                    if (settings.StartupPath != Application.StartupPath)
                    {
                        settings.StartupPath = Application.StartupPath;
                        settings.Save();

                    }

                }
            }
            catch (Exception e)
            {
                Program.log.Error(e);

            }
        }
        /// <summary>
        /// init all settings
        /// </summary>
        public void InitSettings()
        {
            try
            {
                GuiHelper.InitControlEvents();
                LoadSettings();
                if (settings == null)
                {
                    settings = new SettingModel(Program.SettingsPath);
                }

                if (CurrentTemplate == null)
                {
                    ts.Enabled = false;
                    container.Enabled = true;
                    tsmExportToDb.Enabled = false;
                    tsmSaveTemplate.Enabled = false;
                    tsmGenerateFullTemplate.Enabled = false;
                    tsmGenerateSelectedElement.Enabled = false;



                }
            }
            catch (Exception e)
            {
                Program.log.Error(e);
            }
        }

        /// <summary>
        /// form show event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                InitSettings();
            }
            catch (Exception exception)
            {
                Program.log.Error(exception);
            }
        }
        #endregion


    }


}