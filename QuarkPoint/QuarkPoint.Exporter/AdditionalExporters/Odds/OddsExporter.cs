using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuarkPoint.Exporter.AdditionalExporters.Opiu.Opius;
using QuarkPoint.Exporter.AdditionalExporters.Stylers;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.HardModels.Odds;
using QuarkPoint.Exporter.Models.HardModels.Opiu;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Odds
{
    public static class OddsExporter
    {
        private static List<OpiuCommentsModel> comments = new List<OpiuCommentsModel>();

        /// <summary>
        ///     export opiu
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="body"></param>
        public static void ExportOdds(object currentProject, Body body)
        {
            try
            {
                dynamic obj = currentProject;
                var r_obj = JsonConvert.DeserializeObject(obj.ToString());

                object oObj = r_obj["FinDataOdds"];
                var o = oObj.ToString();


                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                var model = JsonConvert.DeserializeObject<FinDataOddsModel>(o, settings);
                var index = 0;
               
                    comments = new List<OpiuCommentsModel>();

                    AddHoryzontalPage(body);

                    GenerateHeader(body, "ПРОГНОЗ ДВИЖЕНИЯ ДЕНЕЖНЫХ СРЕДСТВ");

                    GenerateBody(body, model.Odds);

                    if (comments.Count > 0)
                        GenerateComments(body);
                    
                    index++;
                    var run = new Run();
                    run.Append(new Break());

                    var tParagraph = new Paragraph();

                    tParagraph.Append(run);

                    body.Append(tParagraph);
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #region helpers

        private static void AddHoryzontalPage(Body body)
        {
            try
            {
                var paragraph = new Paragraph(
                    new Run(
                        new Break {Type = BreakValues.Page}));

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
                var header = name;

                //header += "\"" + name + "\"";

                var element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph
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
        ///     generate  table header
        /// </summary>
        /// <param name="table"></param>
        private static void GenerateTableHeader(OddsModel model, Table table)
        {
            try
            {
                var row = new TableRow();
                var descript = new TemplateElement
                {
                    ElementType = ElementType.Текст
                };


                descript.Paragraph = new TemplateParagraph
                {
                    Text = "Наименование",
                    BackgroundColor = "#f2f2f2",
                    TextAlign = TextAlign.Center,
                    FontWeight = FontWeight.Bold,
                    FontSize = 9
                };
                var tc = new TableCell();
                var paragraph = GenerateTableHelper.InitDefaultCellStyle(descript,
                    FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));

                tc.Append(OddsStyler.GetOddsTableHeaderCellProperties());

                tc.Append(paragraph);

                // Assume you want columns that are automatically sized.
                //tc.Append(new TableCellProperties(
                //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                row.Append(tc);
                foreach (var month in model.Header)
                {
                    var element = new TemplateElement
                    {
                        ElementType = ElementType.Текст
                    };


                    element.Paragraph = new TemplateParagraph
                    {
                        Text = month.Name,
                        BackgroundColor = "#f2f2f2",
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Bold,
                        FontSize = 9
                    };
                    var tc1 = new TableCell();
                    var paragraph1 = GenerateTableHelper.InitDefaultCellStyle(element,
                        FormattingHelper.FormatTableElements(element, element.Paragraph.Text));


                    tc1.Append(paragraph1);

                    //tc1.Append(new TableCellProperties(
                    //    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                    tc1.Append(OddsStyler.GetOddsTableHeaderCellProperties());

                    row.Append(tc1);
                }


                

                
                table.Append(row);
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        #region generate line

        /// <summary>
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
        ///     generate sub rows
        /// </summary>
        private static void GenerateSubRows(Table table, dynamic subRows)
        {
            try
            {
                foreach (var subRow in subRows)
                {
                    var r = subRow;
                    var row = new TableRow();
                    var fields = new List<string>();

                    fields.Add(r["Title"].ToString());
                    JObject attributesAsJObject = r;
                    var values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                    foreach (var v in values)
                        if (v.Key.StartsWith("m"))
                            fields.Add(r[v.Key].ToString());

                    fields.Add(r["Prediction"].ToString());

                    foreach (var v in values)
                        if (v.Key.StartsWith("M"))
                            fields.Add(r[v.Key].ToString());


                    foreach (var field in fields)
                    {
                        var descript = new TemplateElement
                        {
                            ElementType = ElementType.Текст
                        };


                        descript.Paragraph = new TemplateParagraph
                        {
                            Text = field,
                            BackgroundColor = "#ffffff",
                            ForegroundColor = "#404040",
                            TextAlign = TextAlign.Center,
                            FontSize = 8,
                            FontWeight = FontWeight.Italic
                        };
                        var tc = new TableCell();
                        var paragraph = GenerateTableHelper.InitDefaultCellStyle(descript,
                            FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                        tc.Append(paragraph);

                        // Assume you want columns that are automatically sized.
                        tc.Append(new TableCellProperties(
                            new TableCellWidth {Type = TableWidthUnitValues.Auto}));


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
        /// </summary>
        private static void GenerateLine(Table table, object line)
        {
            try
            {
                var t = line.ToString();
                dynamic r = JsonConvert.DeserializeObject(t);


                var row = new TableRow();
                var fields = new List<string>();
                string title = r["Title"].ToString();
                fields.Add(r["Title"].ToString());
                JObject attributesAsJObject = r;
                var values = attributesAsJObject.ToObject<Dictionary<string, object>>();

                foreach (var v in values)
                    if (v.Key.StartsWith("m"))
                        fields.Add(r[v.Key].ToString());

                fields.Add(r["Prediction"].ToString());

                foreach (var v in values)
                    if (v.Key.StartsWith("M"))
                        fields.Add(r[v.Key].ToString());
                
                bool subRowsExists = CheckSubRowsExists(r);

                foreach (var field in fields)
                {
                    var descript = new TemplateElement
                    {
                        ElementType = ElementType.Текст
                    };


                    descript.Paragraph = new TemplateParagraph
                    {
                        Text = field,
                        BackgroundColor = "#ffffff",
                        TextAlign = TextAlign.Center,
                        FontSize = 8
                    };
                    if (subRowsExists) descript.Paragraph.FontWeight = FontWeight.BoldItalic;

                    OddsStyler.GetOddsTableParagraphProperties(title, descript.Paragraph);
                    var tc = new TableCell();
                    var paragraph = GenerateTableHelper.InitDefaultCellStyle(descript,
                        FormattingHelper.FormatTableElements(descript, descript.Paragraph.Text));


                    tc.Append(paragraph);

                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                        new TableCellWidth {Type = TableWidthUnitValues.Auto}));

                    var prop = OddsStyler.GetOddsTableRowCellProperties(title);
                    if (prop != null)
                        tc.Append(prop);
                    row.Append(tc);
                }

                table.Append(row);

                if (subRowsExists)
                    GenerateSubRows(table, r["Rows"]);

                if (CheckComments(r))
                {
                    string comment = r["Comments"].ToString();
                    comments.Add(new OpiuCommentsModel(title, comment));
                }
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        /// <summary>
        ///     generate body
        /// </summary>
        public static void GenerateBody(Body body, OddsModel model)
        {
            try
            {
                
                var table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);

                GenerateTableHeader(model, table);


                ///generate body
                dynamic rows = model.Table;
                foreach (var element in rows)
                    GenerateLine(table, element);

                body.Append(table);
            }
            catch (Exception e)
            {
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
        #endregion
    }
}