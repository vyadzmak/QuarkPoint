using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Tester.Helpers.IO;

namespace QuarkPoint.Tester.Helpers.TestExports
{
    public static class CurrentProjectExporter
    {
        /// <summary>
        /// export element
        /// </summary>
        public static void ExportCurrentProject()
        {
            try
            {
                var template = Program.MainForm.CurrentTemplate;
                string fileName = FileNameGenerator.GetFileName();
                string path = Path.Combine(Program.MainForm.settings.TempFolder, fileName);
                GenerateProcessor.ExportDocument(Program.MainForm.CurrentProject, template, path);
                string args = "\"" + path + "\"";
                Process.Start("winword", args);

            }
            catch (Exception e)
            {
            }
        }
    }
}
