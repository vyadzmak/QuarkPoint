using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkPoint.Exporter.Models.ParseModels;

namespace QuarkPoint.Exporter.Helpers
{
    public static class DataInitializer
    {
        /// <summary>
        /// init data models
        /// </summary>
        /// <returns></returns>
        public static string InitData(object currentProject, List<VariableModel> vars, string line)
        {
            try
            {
                foreach (var variableModel in vars)
                {
                    string rs = JHelper.GetValueFromProject(currentProject, variableModel);

                    if (!string.IsNullOrEmpty(rs))
                    {
                        line = line.Replace(variableModel.Name, rs);
                    }
                }
                return line;
            }
            catch (Exception e)
            {
                return line;
            }
        }
    }
}
