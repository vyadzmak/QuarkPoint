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
