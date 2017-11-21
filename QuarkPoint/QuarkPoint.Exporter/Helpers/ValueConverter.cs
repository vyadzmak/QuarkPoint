using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Helpers
{
    public static class ValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConvertDate(string date)
        {
            try
            {
                DateTime _date = DateTime.Parse(date);

                return _date.ToShortDateString();
            }
            catch (Exception e)
            {
                return date;
            }
        }

        public static string ConvertFloat(string toString)
        {
            try
            {
                double d = double.Parse(toString);

                d = Math.Round(d, 2);

                return d.ToString();
            }
            catch (Exception e)
            {
                return toString;
            }
        }
    }
}
