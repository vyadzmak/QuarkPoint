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
        /// generate paragraph
        /// </summary>
        public static void GenerateTable(Body body,TemplateElement element)
        {
            try
            {

                var xTable = element.Table;
                Table table = new Table();

                TableProperties props = new TableProperties(
                    new TableBorders(
                        new TopBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new BottomBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new LeftBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new RightBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideHorizontalBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        },
                        new InsideVerticalBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 1
                        }));

                TableProperties tblProps = new TableProperties();
                TableWidth tableWidth = new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct };

                TableStyle tableStyle = new TableStyle() { Val = "TableGrid" };
                tblProps.Append(tableStyle, tableWidth);
                table.Append(tblProps);
                table.AppendChild<TableProperties>(props);

                for (var i = 0; i < xTable.Rows.Count; i++)
                {
                    var tr = new TableRow();
                    for (var j = 0; j < xTable.Rows[i].Cells.Count; j++)
                    {
                        var tc = new TableCell();



                        tc.Append(new Paragraph(new Run(new Text(xTable.Rows[i].Cells[j].Value))));

                        // Assume you want columns that are automatically sized.
                        tc.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                        tr.Append(tc);
                    }
                    table.Append(tr);
                }
                body.Append(table);

            }
            catch (Exception e)
            {
            }
        }
    }
}
