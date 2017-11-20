using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.TemplateModels;
using QuarkPoint.Tester.Helpers.GUI;
using QuarkPoint.Tester.Helpers.IO;
using QuarkPoint.Tester.Helpers.ReuestHelpers;

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
                ///не забыть добавить сюда DEEPCLONE
                /// 
                string templateName = Program.MainForm.CurrentTemplate.Name + ".json";
                string templatePath = Path.Combine(Program.MainForm.settings.TemplateFolder, templateName);
                Program.MainForm.CurrentTemplate.Save(templatePath);

                TemplateModel template = Program.MainForm.CurrentTemplate;
                string _fileName = FileNameGenerator.GetFileName();
                string path = Path.Combine(Program.MainForm.settings.TempFolder, _fileName);
                

                GenerateProcessor.ExportDocument(Program.MainForm.CurrentProject, template, path);
                string args = "\"" + path + "\"";
                Process.Start("winword", args);


                string fileName = Program.MainForm.ofd.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    Program.MainForm.CurrentTemplate = new TemplateModel();
                    //Program.MainForm.CurrentTemplate.Load(fileName);

                    using (StreamReader file = File.OpenText(fileName))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Program.MainForm.CurrentTemplate =
                            (TemplateModel) serializer.Deserialize(file, typeof(TemplateModel));
                        GuiEventListeners.UnlockControlsWithNewTemplate();
                        GuiListHelper.LoadElements();
                        GuiEventListeners.UpdateFormTitle();
                        string projectString = RequestHelper.GetRequest();

                        JavaScriptSerializer s = new JavaScriptSerializer();
                        dynamic t1 = s.DeserializeObject(projectString);

                        dynamic obj = JsonConvert.DeserializeObject(t1.ToString());
                        string ss = obj.ProjectContent.ToString();


                        dynamic r_obj = JsonConvert.DeserializeObject(obj.ProjectContent.ToString());
                        Program.MainForm.CurrentProject = r_obj;
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
