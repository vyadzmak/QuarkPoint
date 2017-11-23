using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using QuarkPoint.Exporter.Helpers;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.AdditionalExporters.Stylers
{
    public class OpiuStyler
    {
        /// <summary>
        /// get header style
        /// </summary>
        /// <returns></returns>
        public static TableCellProperties GetOpiuTableHeaderCellProperties()
        {
            try
            {
                return TableCellStyler.SetTableCellProperties("#f2f2f2", "#000000");
            }
            catch (Exception e)
            {
                return new TableCellProperties();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static TableCellProperties GetOpiuTableRowCellProperties(string title)
        {
            try
            {
                List<string> titles = new List<string>()
                {
                    "Маржа",
                    "ВАЛОВАЯ ПРИБЫЛЬ",
                    "Итого расходы по бизнесу",
                    "ПРИБЫЛЬ ПО БИЗНЕСУ",
                    "ЧИСТАЯ ПРИБЫЛЬ",
                    "Чистый остаток по кредитам",
                    "Максимальный размер возможного дополнительного взноса (в зависимости от цели):",
                };
                if (titles.Contains(title))
                {
                    return TableCellStyler.SetTableCellProperties("#f2f2f2", "#000000");
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                return new TableCellProperties();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static void GetOpiuTableParagraphProperties(string title,TemplateParagraph paragraph)
        {
            try
            {
                List<string> titles = new List<string>()
                {
                    "Маржа",
                    "ВАЛОВАЯ ПРИБЫЛЬ",
                    "Итого расходы по бизнесу",
                    "ПРИБЫЛЬ ПО БИЗНЕСУ",
                    "ЧИСТАЯ ПРИБЫЛЬ",
                    "Чистый остаток по кредитам",
                    "Максимальный размер возможного дополнительного взноса (в зависимости от цели):",
                };
                if (titles.Contains(title))
                {

                    paragraph.BackgroundColor = "#f2f2f2";
                    paragraph.TextAlign = TextAlign.Center;
                    paragraph.FontSize = 8;
                    paragraph.FontWeight = FontWeight.Bold;
                }
                
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
