using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuarkPoint.Exporter.AdditionalExporters.Stylers;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Opiu;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Opiu.Opius
{
    public static class OpiusExporter
    {
        private static List<OpiuCommentsModel> comments = new List<OpiuCommentsModel>();
        #region helpers
        public static void AddHoryzontalPage(Body body)
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
        private static void GenerateHeader(Body body, string name)
        {
            try
            {


                string header = "ОТЧЕТ О ПРИБЫЛЯХ И УБЫТКАХ ";
                
                header +="\""+ name+"\"";

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
        private static void GenerateTableHeader(OpiuModel model, Table table)
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

                tc.Append(OpiuStyler.GetOpiuTableHeaderCellProperties());

                tc.Append(paragraph);

                // Assume you want columns that are automatically sized.
                //tc.Append(new TableCellProperties(
                //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                row.Append(tc);
                foreach (var month in model.Months)
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

                    //tc1.Append(new TableCellProperties(
                    //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                    tc1.Append(OpiuStyler.GetOpiuTableHeaderCellProperties());

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
                //tc.Append(new TableCellProperties(
                //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                tc.Append(OpiuStyler.GetOpiuTableHeaderCellProperties());

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
                //tc.Append(new TableCellProperties(
                //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                tc.Append(OpiuStyler.GetOpiuTableHeaderCellProperties());

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
        /// <param name="row"></param>
        /// <returns></returns>
        private static bool CheckSubRowsExists(dynamic row)
        {
            try
            {
                var subRows = row["Rows"];
                if (subRows == null) return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static bool CheckComments(dynamic row)
        {
            try
            {
                var subRows = row["Comments"];
                if (subRows == null) return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        ///generate sub rows 
        /// </summary>
        private static void GenerateSubRows(Table table,dynamic subRows)
        {
            try
            {
                foreach (var subRow in subRows)
                {
                    dynamic r = subRow;
                    TableRow row = new TableRow();
                    List<string> fields = new List<string>();

                    fields.Add(r["Title"].ToString());
                    JObject attributesAsJObject = r;
                    Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                    foreach (KeyValuePair<string, object> v in values)
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
                            ForegroundColor = "#404040",
                            TextAlign = TextAlign.Center,
                            FontSize = 8,
                            FontWeight = FontWeight.Italic
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
            }
            catch (Exception e)
            {
            }
        }

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
                string title = r["Title"].ToString();
                fields.Add(r["Title"].ToString());
                JObject attributesAsJObject = r;
                Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                foreach (KeyValuePair<string, object> v in values)
                {
                    if (v.Key.StartsWith("M"))
                    {
                        fields.Add(r[v.Key].ToString());
                    }
                }
                fields.Add(r["Avg"].ToString());
                fields.Add(r["AvgPrediction"].ToString());
                bool subRowsExists = CheckSubRowsExists(r);

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
                        FontSize = 8
                    };
                    if (subRowsExists) descript.Paragraph.FontWeight = FontWeight.BoldItalic;
                    
                    OpiuStyler.GetOpiuTableParagraphProperties(title, descript.Paragraph);
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(descript, FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                    tc.Append(paragraph);

                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    TableCellProperties prop = OpiuStyler.GetOpiuTableRowCellProperties(title);
                    if (prop != null)
                        tc.Append(prop);
                    row.Append(tc);
                }

                table.Append(row);

                if (subRowsExists)
                {
                    GenerateSubRows(table,r["Rows"]);
                }

                if (CheckComments(r))
                {
                    string comment = r["Comments"].ToString();
                    comments.Add(new OpiuCommentsModel(title,comment));
                }
            }
            catch (Exception e)
            {
            }
        }

        #endregion
        /// <summary>
        /// generate body
        /// </summary>
        public static void GenerateBody(Body body, OpiuModel model)
        {
            try
            {
                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);

                GenerateTableHeader(model, table);


                ///generate body
                dynamic rows = model.Table;
                foreach (var element in rows)
                {
                    GenerateLine(table, element);
                }

                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }
        #endregion
        /// <summary>
        /// export opiu
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="body"></param>
        public static void ExportOpiu(object currentProject, Body body)
        {
            try
            {
                dynamic obj = currentProject;
                dynamic r_obj = JsonConvert.DeserializeObject(obj.ToString());

                object oObj = r_obj["FinDataOpiu"];
                string o = oObj.ToString();


                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                FinDataOpiuModel fMdl = JsonConvert.DeserializeObject<FinDataOpiuModel>(o, settings);
                int index = 0;
                foreach (var model in fMdl.Opius)
                {

                    comments = new List<OpiuCommentsModel>();

                    AddHoryzontalPage(body);

                    GenerateHeader(body, fMdl.Companies[index].Name);

                    GenerateBody(body, model);

                    if (comments.Count > 0)
                    {
                        GenerateComments(body);

                    }
                    if (model.LoanContributionDetails != null)
                    {
                        AdditionalOpiuTableExporter.ExportLoanContributionDetailsTable(body,model.LoanContributionDetails);
                    }

                    if (model.TotalRealtedCompanyRevenue != null && model.RelatedCompanyRevenues != null)
                    {
                        AdditionalOpiuTableExporter.ExportRelatedCompanyRevenue(body,model, model.RelatedCompanyRevenues, model.TotalRealtedCompanyRevenue);
                    }
                    index++;
                    Run run = new Run();
                    run.Append(new Break());

                    var tParagraph = new Paragraph();

                    tParagraph.Append(run);

                    body.Append(tParagraph);
                }
            }
            catch (Exception e)
            {
                

                throw;
            }
        }

        private static void GenerateComments(Body body)
        {
            try
            {
                string header = "Комментарии: ";
                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);

                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);

                foreach (var comment in comments)
                {
                    TableRow row = new TableRow();

                    TemplateElement commentTitle = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };


                    commentTitle.Paragraph = new TemplateParagraph()
                    {
                        Text = comment.Title,
                        BackgroundColor = "#ffffff",
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Bold,
                        FontSize = 8
                    };
                    
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(commentTitle, FormattingHelper.FormatTableElements(commentTitle, commentTitle.Paragraph.Text));
                    tc.Append(paragraph);
                    tc.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    row.Append(tc);


                    TemplateElement commentValue = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };


                    commentValue.Paragraph = new TemplateParagraph()
                    {
                        Text = comment.Value,
                        BackgroundColor = "#ffffff",
                        TextAlign = TextAlign.Center,
                        FontSize = 8
                    };

                    var tc1 = new TableCell();
                    Paragraph paragraph1 = GenerateTableHelper.InitDefaultCellStyle(commentValue, FormattingHelper.FormatTableElements(commentValue, commentValue.Paragraph.Text));
                    tc1.Append(paragraph1);
                    tc1.Append(new TableCellProperties(
                        new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                    row.Append(tc1);

                    table.Append(row);
                }

                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }
    }
}
