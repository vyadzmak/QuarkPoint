using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Helpers
{
    public static class RegExpHelper
    {
        /// <summary>
        /// search between two chars
        /// </summary>
        /// <returns></returns>
        public static List<string> SearchBetweenTwoStrings(string leftString, string rightString, string line)
        {
            try
            {
                List<string> results = new List<string>();
                string pattern = @"\" + leftString + ".*?" + @"\" + rightString;
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(line))
                {
                    var matches = regex.Matches(line);

                    foreach (Match match in matches)
                    {
                        results.Add(match.Value);
                    }
                }

                return results;
                
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
