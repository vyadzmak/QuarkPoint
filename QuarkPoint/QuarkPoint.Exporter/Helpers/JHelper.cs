using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
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

        /// <summary>
        /// get to array elements
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static List<string> GetToArrayElements(object currentProject, VariableModel variable)
        {
            try
            {
                string lastName = variable.PathVars[variable.PathVars.Count - 1];

                object result = currentProject;
                variable.PathVars.Remove(variable.PathVars[variable.PathVars.Count - 1]);
                foreach (var variablePathVar in variable.PathVars)
                {
                    result = GetToVarByPath(result, variablePathVar);
                }
                
                dynamic ar = result;
                List<string> fields = new List<string>();
                foreach (var tmp in ar[lastName])
                {
                   
                    dynamic stuff = JsonConvert.DeserializeObject(tmp.ToString());

                    JObject attributesAsJObject =stuff;
                    Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
                    foreach (string key in values.Keys)
                    {
                       fields.Add(key);
                    }
                    break;
                }

                return fields;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>
        /// get to array elements
        /// </summary>
        /// <param name="currentProject"></param>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static List<List<string>> GetToArrayValues(object currentProject, List<VariableModel> variables)
        {
            try
            {
                List<List<string>> results = new List<List<string>>();
                if (variables.Count <= 0) return null;
                string vName = variables[0].Name;
                List<string> paths = new List<string>();
                paths.AddRange(variables[0].PathVars);

                VariableModel variable =
                    new VariableModel(vName) {PathVars = paths};

                
                string lastName = variable.PathVars[variable.PathVars.Count - 2];

                object result = currentProject;
                variable.PathVars.Remove(variable.PathVars[variable.PathVars.Count - 1]);

                foreach (var variablePathVar in variable.PathVars)
                {
                    result = GetToVarByPath(result, variablePathVar);
                }

                dynamic ar = result;
                List<string> tmpResults = new List<string>();
                foreach (var tmp in ar)
                {

                    
                    foreach (var v in variables)
                    {
                        string name = tmp[v.PathVars[v.PathVars.Count - 1]];
                        tmpResults.Add(name);
                    }

                    results.Add(tmpResults);
                    tmpResults = new List<string>();
                }
                return results;
                //return fields;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
