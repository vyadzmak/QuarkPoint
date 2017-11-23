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
    public class OddsStyler
    {
        /// <summary>
        /// get header style
        /// </summary>
        /// <returns></returns>
        public static TableCellProperties GetOddsTableHeaderCellProperties()
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
        public static TableCellProperties GetOddsTableRowCellProperties(string title)
        {
            try
            {
                List<string> titles = new List<string>()
                {
                    "ДЕН. СР-ВА НА НАЧАЛО ПЕРИОДА",
                    "ПРИХОД ДЕНЕЖНЫХ СРЕДСТВ",
                    "ИТОГО выручка от операционной деятельности по бизнесу",
                    "ИТОГО выручка от вне операционной деятельности по бизнесу",
                    "РАСХОД ДЕНЕЖНЫХ СРЕДСТВ",
                    "ИТОГО операционные расходы по бизнесу:",
                    "ИТОГО вне операционные расходы по бизнесу:",
                    "ДЕН. СР-ВА НА КОНЕЦ МЕСЯЦА",
                    "ДЕН. СР-ВА НА КОНЕЦ ПЕРИОДА",
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
        public static void GetOddsTableParagraphProperties(string title,TemplateParagraph paragraph)
        {
            try
            {
                List<string> titles = new List<string>()
                {
                    "ДЕН. СР-ВА НА НАЧАЛО ПЕРИОДА",
                    "ПРИХОД ДЕНЕЖНЫХ СРЕДСТВ",
                    "ИТОГО выручка от операционной деятельности по бизнесу",
                    "ИТОГО выручка от вне операционной деятельности по бизнесу",
                    "РАСХОД ДЕНЕЖНЫХ СРЕДСТВ",
                    "ИТОГО операционные расходы по бизнесу:",
                    "ИТОГО вне операционные расходы по бизнесу:",
                    "ДЕН. СР-ВА НА КОНЕЦ МЕСЯЦА",
                    "ДЕН. СР-ВА НА КОНЕЦ ПЕРИОДА",
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
