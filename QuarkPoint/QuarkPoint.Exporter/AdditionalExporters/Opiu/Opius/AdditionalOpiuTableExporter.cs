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
    public static class AdditionalOpiuTableExporter
    {
        
        private static void GenerateParagraph(Body body, string header)
        {
            try
            {
                if (header==null) return;
                
                TemplateElement element = new TemplateElement();
                element.ElementType = ElementType.Текст;

                element.Paragraph = new TemplateParagraph()
                {
                    TextAlign = TextAlign.Left,
                    FontWeight = FontWeight.Bold,
                    Text = header
                };
                GenerateParagraphHelper.GenerateParagraph(body, element);




            }
            catch (Exception e)
            {

            }
        }
        private static void GenerateTableHeader(Table table, List<string> headers)
        {
            try
            {
                TableRow row = new TableRow();

                foreach (var header in headers)
                {
                    TemplateElement headerElement = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };
                    headerElement.Paragraph = new TemplateParagraph()
                    {
                        Text = header,
                        BackgroundColor = "#f2f2f2",
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Bold,
                        FontSize = 9
                    };
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(headerElement,
                        FormattingHelper.FormatTableElements(headerElement, headerElement.Paragraph.Text));

                    tc.Append(OpiuStyler.GetOpiuTableHeaderCellProperties());
                    tc.Append(paragraph);
                    row.Append(tc);
                }
                table.Append(row);
            }
            catch (Exception e)
            {
            }
        }

        private static void GenerateTableRow(Table table, List<string> cells)
        {
            try
            {
                TableRow row = new TableRow();

                foreach (var cell in cells)
                {
                    TemplateElement cellElement = new TemplateElement()
                    {
                        ElementType = ElementType.Текст
                    };
                    cellElement.Paragraph = new TemplateParagraph()
                    {
                        Text = cell,
                        BackgroundColor = "#ffffff",
                        TextAlign = TextAlign.Center,
                        FontWeight = FontWeight.Normal,
                        FontSize = 9
                    };
                    var tc = new TableCell();
                    Paragraph paragraph = GenerateTableHelper.InitDefaultCellStyle(cellElement,
                        FormattingHelper.FormatTableElements(cellElement, cellElement.Paragraph.Text));

                    
                    tc.Append(paragraph);
                    row.Append(tc);
                }
                table.Append(row);
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void ExportLoanContributionDetailsTable(Body body,LoanContributionDetailsModel model)
        {
            try
            {
                if (model.Rows==null || model.Rows.Count==0) return;
                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);

                GenerateParagraph(body, "РАСШИФРОВКА ВЗНОСОВ ПО КРЕДИТУ");

                List<string> headers = new List<string>()
                {
                    "Заемщик",
                    "БВУ",
                    "Действующие об.",
                    "Вид финансирования",
                    "Лимит финансирования",
                    "Сумма взноса основного долга",
                    "Сумма взноса вознаграждения",
                    "Учитывать полный взнос",
                    "Итого"
                };

                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);
                GenerateTableHeader(table,headers);

                foreach (var row in model.Rows)
                {
                    List<string> cells = new List<string>();
                    cells.Add(row.Name);
                    cells.Add(row.BankName);
                    string isCurrent = row.IsCurrent ? "Да" : "Нет";
                    cells.Add(isCurrent);
                    cells.Add(row.LoanType.Name);
                    cells.Add(row.LimitSum.ToString());
                    cells.Add(row.Principal.ToString());
                    cells.Add(row.Fee.ToString());
                    string isPrincipal = row.IsCurrent ? "Да" : "Нет";
                    cells.Add(isPrincipal);
                    cells.Add(row.ForOpiu.ToString());
                    GenerateTableRow(table,cells);
                }

                List<string> footer = new List<string>()
                {
                    "",
                    "",
                    "",
                    "",
                    "Итого",
                    model.TotalPrincipal.ToString(),
                    model.TotalFee.ToString(),
                    "",
                    model.TotalForOpiu.ToString()
                };
                GenerateTableRow(table,footer);
                body.Append(table);
                GenerateParagraph(body,model.Comments);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExportRelatedCompanyRevenue(Body body,OpiuModel model, List<object> rows, object total)
        {
            try
            {
                if (rows==null) return;
                if (rows.Count==0) return;

                Run run = new Run();
                run.Append(new Break());

                var tParagraph = new Paragraph();

                tParagraph.Append(run);

                body.Append(tParagraph);
                GenerateParagraph(body, "ВЫРУЧКА ОТ РЕАЛИЗАЦИИ СВЯЗАННЫМ КОМПАНИЯМ");

                List<string> headers = new List<string>();
                headers.Add("Наименование");
                foreach (var month in model.Months)
                {
                    headers.Add(month.Name);
                }
                headers.Add("Среднее текущее");

                Table table = new Table();
                TableStyleGenerator.SetDefaultTableStyle(table);
                GenerateTableHeader(table, headers);
                List<string> mList = new List<string>();

                foreach (var line in rows)
                {
                    var t = line.ToString();
                    dynamic r = JsonConvert.DeserializeObject(t);
                    List<string> fields = new List<string>();
                    fields.Add(r["Name"].ToString());
                    JObject attributesAsJObject = r;
                    Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                    foreach (KeyValuePair<string, object> v in values)
                    {
                        if (v.Key.StartsWith("M"))
                        {
                            fields.Add(r[v.Key].ToString());
                            mList.Add(v.Key);
                        }
                    }
                    fields.Add(r["Avg"].ToString());
                    GenerateTableRow(table,fields);
                }

                dynamic ob = JsonConvert.DeserializeObject(total.ToString());

                List<string> cols = new List<string>();

                cols.Add("Итого");
                foreach (var m in mList)
                {
                   cols.Add(ob[m].ToString());
                }
                cols.Add(ob["Avg"].ToString());
                GenerateTableRow(table, cols);


                body.Append(table);
            }
            catch (Exception e)
            {
            }
        }
    }
}
