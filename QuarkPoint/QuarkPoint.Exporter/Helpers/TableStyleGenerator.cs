using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace QuarkPoint.Exporter.Helpers
{
    public static class TableStyleGenerator
    {
        /// <summary>
        /// set default style to table
        /// </summary>
        /// <param name="table"></param>
        public static void SetDefaultTableStyle(Table table)
        {
            try
            {
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
            }
            catch (Exception e)
            {
            }
        }

    }
}
