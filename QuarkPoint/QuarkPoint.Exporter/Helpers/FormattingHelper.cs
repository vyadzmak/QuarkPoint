using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Models.TemplateModels;

namespace QuarkPoint.Exporter.Helpers
{
    public static class FormattingHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string FormatParagraphElements(TemplateElement element, string value)
        {
            try
            {
                var formats = element.Paragraph.Formatting;

                string result = value;


                foreach (var format in formats)
                {
                    if (value.ToLower().Contains(format.From.ToLower()))
                    {
                        value =value.Replace(format.From, format.To);
                    }
                }

                return value;

            }
            catch (Exception e)
            {
                return value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string FormatTableElements(TemplateElement element, string value)
        {
            try
            {
                var formats = element.Table.Formatting;

                string result = value;


                foreach (var format in formats)
                {
                    if (format.From.ToLower().Equals(value.ToLower()))
                    {
                        result = format.To;
                    }
                }

                return result;

            }
            catch (Exception e)
            {
                return value;
            }
        }
    }
}
