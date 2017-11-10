using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuarkPoint.Tester.Models.Settings
{

    /// <summary>
    /// setting model
    /// </summary>
    public class SettingModel
    {
        #region constructor
        /// <summary>
        /// constructor without params
        /// </summary>
        public SettingModel()
        {
            try
            {

            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// constructor without params
        /// </summary>
        public SettingModel(string settingsPath)
        {
            try
            {
                this.SettingsPath = settingsPath;
                this.StartupPath = Application.StartupPath;
                this.TempFolder = Path.Combine(StartupPath, "temp");
                this.ReportFolder = Path.Combine(StartupPath, "reports");
                this.TemplateFolder = Path.Combine(StartupPath, "templates");


                CheckFolder(TempFolder);
                CheckFolder(ReportFolder);
                CheckFolder(TemplateFolder);


                this.Save();


                //check folders
            }
            catch (Exception e)
            {
                Program.log.Error(e);

            }
        }
        #endregion

        #region methods
        /// <summary>
        /// check folder
        /// </summary>
        private void CheckFolder(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception e)
            {
                Program.log.Error(e);

            }
        }
        /// <summary>
        /// load settings
        /// </summary>
        public void Load()
        {
            try
            {
               
            }
            catch (Exception e)
            {
                Program.log.Error(e);
            }
        }

        /// <summary>
        /// save settings
        /// </summary>
        public void Save()
        {
            try
            {
                using (StreamWriter file = File.CreateText(this.SettingsPath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.QuoteChar = '\'';

                    JsonSerializer ser = new JsonSerializer();
                    ser.Serialize(writer, this);
                }

                
            }
            catch (Exception e)
            {
                Program.log.Error(e);
            }
        }
        #endregion

        #region fields
        [JsonIgnore]
        public string AppName = "Quark";
        /// <summary>
        /// settings path
        /// </summary>
        [JsonProperty("settings_path")]
        public string SettingsPath { get; set; }
        /// <summary>
        /// startup path
        /// </summary>
        [JsonProperty("startup_path")]
        public string StartupPath { get; set; }

        /// <summary>
        /// temp folder
        /// </summary>
        [JsonProperty("temp_folder")]
        public string TempFolder { get; set; }

        /// <summary>
        /// temp folder
        /// </summary>
        [JsonProperty("report_folder")]
        public string ReportFolder { get; set; }

        /// <summary>
        /// temp folder
        /// </summary>
        [JsonProperty("template_folder")]
        public string TemplateFolder { get; set; }
        #endregion

    }
}
