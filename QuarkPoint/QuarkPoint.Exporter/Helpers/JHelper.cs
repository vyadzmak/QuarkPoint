using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using QuarkPoint.Exporter.Models.ParseModels;

namespace QuarkPoint.Exporter.Helpers
{
    /// <summary>
    /// JSON to Object helper
    /// </summary>
    public static class JHelper
    {
        /// <summary>
        /// get to var
        /// </summary>
        /// <param name="var"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static object GetToVarByPath(dynamic var, string name)
        {
            try
            {
                return var[name];
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// get to value
        /// </summary>
        /// <returns></returns>
        public static string GetValueFromProject(object currentProject, VariableModel variable)
        {
            try
            {
                object result = currentProject;
                foreach (var variablePathVar in variable.PathVars)
                {
                    result = GetToVarByPath(result, variablePathVar);
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
