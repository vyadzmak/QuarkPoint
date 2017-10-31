using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using QuarkPoint.Tester.Helpers.GUI;
using QuarkPoint.Tester.Models.Settings;

namespace QuarkPoint.Tester
{
    public partial class MainForm : Form
    {
        #region variables
        /// <summary>
        /// settings
        /// </summary>
        public SettingModel settings = null;
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