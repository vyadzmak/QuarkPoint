using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Balance;
using QuarkPoint.Exporter.Models.HardModels.Opiu;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Opiu.ConsOpiu
{
    public static class ConsOpiuExporter
    {
        #region helpers
        private static void AddHoryzontalPage(Body body)
        {
            try
            {
                Paragraph paragraph = new Paragraph(
                    new Run(
                        new Break() { Type = BreakValues.Page }));

                body.Append(paragraph);
            }
            catch (Exception e)
            {
            }   
        }
        private static void GenerateHeader(Body body, FinDataOpiuModel model)
        {
            try
            {
                
                
                string header = "КОНСОЛИДИРОВАННЫЙ ОТЧЕТ О ПРИБЫЛЯХ И УБЫТКАХ (";
                int count = 0;
                foreach (var company in model.Companies)
                {
                    header += "\"" + company.Name + "\"";
                    if (count + 1 < model.Companies.Count)
                    {
                        header += ", ";
                    }
                    count++;
                }

                header += ")";

                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Center,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);




            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region generate body
        #region generate table header
        /// <summary>
        /// generate  table header
        /// </summary>
        /// <param name="table"></param>
        private static void GenerateTableHeader(ConsFinDataOpiuModel model,Table table)
        {
            try
            {
                TableRow row = new TableRow();
                TemplateElement descript = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                descript.Paragraph = new TemplateParagraph()
                {
                    Text = "Наименование",
                    BackgroundColor = "#f2f2f2",
                    TextAlign = TextAlign.Center,
                    FontWeight = FontWeight.Bold,
                    FontSize = 9
                };
                var tc = new TableCell();
                Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(descript, FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                tc.Append(paragraph);

                // Assume you want columns that are automatically sized.
                tc.Append(new TableCellProperties(
                    new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                row.Append(tc);
                foreach (var month in model.Opiu.Months)
                {
                    TemplateElement element = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };


                    element.Paragraph = new TemplateParagraph()
                    {
                        Text = month.Name,
                        BackgroundColor = "#f2f2f2",
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Bold,
                        FontSize = 9
                    };
                    var tc1 = new TableCell();
                    Paragraph paragraph1 = GenerateTableHelper.InitDefaultCellStyle(element, FormattingHelper.FormatTableElements(element, element.Paragraph.Text));


                    tc1.Append(paragraph1);
                    
                    tc1.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    row.Append(tc1);
                }


                descript = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                descript.Paragraph = new TemplateParagraph()
                {
                    Text = "Среднее текущее",
                    BackgroundColor = "#f2f2f2",
                    TextAlign = TextAlign.Center,
                    FontWeight = FontWeight.Bold,
                    FontSize = 9
                };
                tc = new TableCell();
                paragraph = GenerateTableHelper.InitDefaultCellStyle(descript, FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                tc.Append(paragraph);

                // Assume you want columns that are automatically sized.
                tc.Append(new TableCellProperties(
                    new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                row.Append(tc);

                descript = new TemplateElement()
                {
                    ElementType = ElementType.Текст
                };


                descript.Paragraph = new TemplateParagraph()
                {
                    Text = "Среднее прогноз",
                    BackgroundColor = "#f2f2f2",
                    TextAlign = TextAlign.Center,
                    FontWeight = FontWeight.Bold,
                    FontSize = 9
                };
                tc = new TableCell();
                paragraph = GenerateTableHelper.InitDefaultCellStyle(descript, FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                tc.Append(paragraph);

                // Assume you want columns that are automatically sized.
                tc.Append(new TableCellProperties(
                    new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                row.Append(tc);
                table.Append(row);
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region generate line

      
        
        
        /// <summary>
        /// 
        /// </summary>
        private static void GenerateLine(Table table, object line)
        {
            try
            {
                
                var t = line.ToString();
                dynamic r = JsonConvert.DeserializeObject(t);
                


                TableRow row = new TableRow();
                List<string> fields = new List<string>();

                fields.Add(r["Title"].ToString());
                JObject attributesAsJObject = r;
                Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                foreach (KeyValuePair<string,object> v in values)
                {
                    if (v.Key.StartsWith("M"))
                    {
                        fields.Add(r[v.Key].ToString());
                    }
                }
                fields.Add(r["Avg"].ToString());
                fields.Add(r["AvgPrediction"].ToString());


                foreach (var field in fields)
                {
                    TemplateElement descript = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };


                    descript.Paragraph = new TemplateParagraph()
                    {
                        Text = field,
                        BackgroundColor = "#ffffff",
                        TextAlign = TextAlign.Center,
                        FontSize = 9
                    };
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(descript, FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                    tc.Append(paragraph);

                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    row.Append(tc);
                }

                table.Append(row);
            }
            catch (Exception e)
            {
            }
        }
        
        #endregion
        /// <summary>
        /// generate body
        /// </summary>
        public static void GenerateBody(Body body, ConsFinDataOpiuModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);

                GenerateTableHeader(model,table);


                ///generate body
                dynamic rows = model.Opiu.Table;
                foreach (var element in rows)
                {
                    GenerateLine(table,element);
                }

                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        /// <summary>
        /// export consolidate opiu
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="body"></param>
        public static void ExportConsolidateOpiu(object currentProject, Body body)
        {
            try
            {
                dynamic obj = currentProject;
                dynamic r_obj = JsonConvert.DeserializeObject(obj.ToString());

                object coObj = r_obj["ConsolidatedOpiu"];
                string co = coObj.ToString();

                object oObj = r_obj["FinDataOpiu"];
                string o = oObj.ToString();


                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                FinDataOpiuModel fMdl = JsonConvert.DeserializeObject<FinDataOpiuModel>(o, settings);

                ConsFinDataOpiuModel cfMdl = JsonConvert.DeserializeObject<ConsFinDataOpiuModel>(co, settings);
                AddHoryzontalPage(body);
                GenerateHeader(body, fMdl);
                GenerateBody(body,cfMdl);
            }
            catch (Exception e)
            {
            }
        }
    }
}
