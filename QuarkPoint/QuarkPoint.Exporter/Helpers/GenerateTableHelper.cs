using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.Helpers
{
    /// <summary>
    /// helper for generate paragraph
    /// </summary>
    public static class GenerateTableHelper
    {
        /// <summary>
        /// init default cell style
        /// </summary>
        public static Paragraph InitDefaultCellStyle(TemplateElement element, string value)
        {
            try
            {
                Paragraph paragraph = new Paragraph();
                var rProperties = ParagraphStyleHelper.GenerateRunProperities(element);
                var pProperties = ParagraphStyleHelper.GenerateParagraphProperties(element);

                Run run = new Run();
                run.Append(rProperties);

                var text = new Text(value);
                run.Append(text);

                var tParagraph = new Paragraph();
                tParagraph.Append(pProperties);
                tParagraph.Append(run);

                
                return tParagraph;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        private static void GenerateHeader(Table table, TemplateElement element)
        {
            try
            {
                var xTable = element.Table;
                for (var i = 0; i < xTable.Headers.Count; i++)
                {
                    var tr = new TableRow();
                    for (var j = 0; j < xTable.Headers[i].Cells.Count; j++)
                    {
                        var tc = new TableCell();
                        Paragraph paragraph = GenerateParagraphHelper.GenerateParagraphByStyle(xTable.Headers[i].Style, xTable.Headers[i].Cells[j].Value);
                        
                        tc.Append(paragraph);

                        // Assume you want columns that are automatically sized.
                        tc.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                        tr.Append(tc);
                    }
                    table.Append(tr);
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// generate paragraph
        /// </summary>
        public static void GenerateTable(Body body,TemplateElement element)
        {
            try
            {

                var xTable = element.Table;
                Table table = new Table();

                TableStyleGenerator.SetDefaultTableStyle(table);
                if (element.Table.Headers!=null && element.Table.Headers.Count > 0)
                {
                    GenerateHeader(table,element);
                }
                for (var i = 0; i < xTable.Rows.Count; i++)
                {
                    var tr = new TableRow();
                    for (var j = 0; j < xTable.Rows[i].Cells.Count; j++)
                    {
                        var tc = new TableCell();

                        Paragraph paragraph = InitDefaultCellStyle(element,FormattingHelper.FormatTableElements(element, xTable.Rows[i].Cells[j].Value));


                        tc.Append(paragraph);

                        // Assume you want columns that are automatically sized.
                        tc.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                        tr.Append(tc);
                    }
                    table.Append(tr);
                }
                body.Append(table);


                //здесь надо применить стили???
            }
            catch (Exception e)
            {
            }
        }
    }
}
