using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;


namespace QuarkPoint.Exporter.Helpers
{
    public static class TableCellStyler
    {
        /// <summary>
        /// set table cell properties
        /// </summary>
        /// <returns></returns>
        public static TableCellProperties SetTableCellProperties(string backColor, string foregroundColor)
        {
            try
            {
                //return new TableCellProperties();
                var tcp = new TableCellProperties();
                // Add cell shading.
                var shading = new Shading()
                {
                    Color =foregroundColor,
                    Fill = backColor,
                    Val = ShadingPatternValues.Clear
                };

                tcp.Append(shading);
                return tcp;
            }
            catch (Exception e)
            {
                return new TableCellProperties();
            }
        }
    }
}
