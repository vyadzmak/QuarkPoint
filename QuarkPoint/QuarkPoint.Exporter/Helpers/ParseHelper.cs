using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Models.ParseModels;

namespace QuarkPoint.Exporter.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class ParseHelper
    {
        /// <summary>
        /// get to vars
        /// </summary>
        /// <returns></returns>
        public static List<VariableModel> GetToVars(string line)
        {
            try
            {
                List<string> matches = RegExpHelper.SearchBetweenTwoStrings("{", "}", line);

                List<VariableModel> models =new List<VariableModel>();

                foreach (var match in matches)
                {
                    VariableModel model = new VariableModel(match);
                    string res = match.Replace("{", string.Empty);

                    res = res.Replace("}", string.Empty);
                    List<string> vars = res.Split('.').ToList();
                    model.PathVars = vars;
                    models.Add(model);
                }

                return models;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
