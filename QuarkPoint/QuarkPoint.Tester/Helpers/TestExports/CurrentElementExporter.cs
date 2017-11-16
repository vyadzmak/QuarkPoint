using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.IO;

namespace QuarkPoint.Tester.Helpers.TestExports
{
    /// <summary>
    /// 
    /// </summary>
    public static class CurrentElementExporter
    {
        
        /// <summary>
        /// export element
        /// </summary>
        public static void ExportCurrentElement()
        {
            try
            {
                var element = Program.MainForm.CurrentElement;
                string fileName = FileNameGenerator.GetFileName();
                string path = Path.Combine(Program.MainForm.settings.TempFolder, fileName);
                GenerateProcessor.ExportElement(Program.MainForm.CurrentProject,element,path);
                string args = "\"" + path + "\"";
                Process.Start("winword",args);
                
            }
            catch (Exception e)
            {
            }
        }


    }
}
