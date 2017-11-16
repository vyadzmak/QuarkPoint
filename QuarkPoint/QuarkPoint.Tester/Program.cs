using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace QuarkPoint.Tester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static MainForm MainForm;
        public static string SettingsPath =System.IO.Path.Combine(Application.StartupPath,"settings.json");
        [STAThread]

        static void Main()
        {

            try
            {
                log = LogManager.GetCurrentClassLogger();

                log.Trace("Version: {0}", Environment.Version.ToString());
                log.Trace("OS: {0}", Environment.OSVersion.ToString());
                log.Trace("Command: {0}", Environment.CommandLine.ToString());

                NLog.Targets.FileTarget tar = (NLog.Targets.FileTarget)LogManager.Configuration.FindTargetByName("file");
                tar.DeleteOldFileOnStartup = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка работы с логом! \n" + e.Message);
            }
            // ловим все не обработанные исключения
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ApplicationException);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(MainForm);
        }

        /// <summary>
        /// terminate application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnApplicationExit(object sender, EventArgs e)
        {
           
            try
            {
                string tempFolder = MainForm.settings.TempFolder;

                string[] files = Directory.GetFiles(tempFolder);

                for (int i = 0; i < files.Length; i++)
                {
                        File.Delete(files[i]); 
                    
                }

            }
            catch { }
        }
    }
}
