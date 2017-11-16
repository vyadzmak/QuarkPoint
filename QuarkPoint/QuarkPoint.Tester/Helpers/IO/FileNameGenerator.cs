using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Tester.Helpers.IO
{
    public static class FileNameGenerator
    {
        /// <summary>
        /// get file name
        /// </summary>
        /// <returns></returns>
        public static string GetFileName()
        {
            try
            {
                string ext = ".docx";
                string dateTime = DateTime.Now.ToString();

                string result = new String(dateTime.Where(Char.IsDigit).ToArray())+ext; ;
                return result;
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
