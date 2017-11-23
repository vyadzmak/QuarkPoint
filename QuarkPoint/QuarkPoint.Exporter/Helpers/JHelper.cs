using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
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
                object result = var[name];

                Type rType = result.GetType();

                string sType = rType.FullName;

                object ex = var[name];
                if (ex == null)
                {
                    string p = "";
                }
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

                JValue res =(JValue) result;

                string r = res.Value.ToString();
                
                string tName = res.Type.ToString();

                if (r.StartsWith("{"))
                {
                    string u = "";
                }

                if (tName.Equals("Date"))
                {
                   r= ValueConverter.ConvertDate(res.Value.ToString());
                }

                if (tName.Equals("Float"))
                {
                    r = ValueConverter.ConvertFloat(res.Value.ToString());
                }


                return r;
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
        /// get parent index
        /// </summary>
        /// <param name="vars"></param>
        /// <returns></returns>
        private static int GetaParentVariableIndex(List<VariableModel> vars)
        {
            try
            {
                int index = 0;
                bool exists = false;

                List<string> uniquePaths = new List<string>();
                foreach (var v in vars)
                {
                    foreach (var vPath in v.PathVars)
                    {
                        if (!uniquePaths.Contains(vPath))
                        {
                            uniquePaths.Add(vPath);
                        }
                    }
                }

                int lastIndex = 0;

                foreach (var uniquePath in uniquePaths)
                {
                    bool existsInAll = true;
                    foreach (var variableModel in vars)
                    {
                        if (!variableModel.PathVars.Contains(uniquePath))
                        {
                            existsInAll = false;
                            break;
                        }
                        else
                        {
                            
                        }
                    }
                    if (!existsInAll)
                    {
                        break;
                    }
                    else
                    {
                        lastIndex++;
                    }
                }

                return lastIndex-1;
            }
            catch (Exception e)
            {
                return -1;
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
                int index = GetaParentVariableIndex(variables);
                List<List<string>> results = new List<List<string>>();
                if (variables.Count <= 0) return null;

                string vName = variables[0].Name;
                List<string> paths = new List<string>();
                paths.AddRange(variables[0].PathVars);

                VariableModel variable =
                    new VariableModel(vName) {PathVars = paths};
                
                object result = currentProject;
                variable.PathVars.Remove(variable.PathVars[variable.PathVars.Count - 1]);

                foreach (var variablePathVar in variable.PathVars)
                {
                    if (!variablePathVar.StartsWith("*"))
                    {
                        result = GetToVarByPath(result, variablePathVar);
                    }
                    else
                    {
                        result = result;
                    }
                }

                dynamic ar = result;
                List<string> tmpResults = new List<string>();
                foreach (var tmp in ar)
                {

                    
                    foreach (var v in variables)
                    {
                        JValue name = null;

                        var ex = v.PathVars.Where(x => x.Contains("*")).FirstOrDefault();
                        if (ex==null)
                        {
                            name = tmp[v.PathVars[v.PathVars.Count - 1]];
                        }
                        else
                        {
                            string p = ex.Replace("*","");

                            var tmpObj = tmp[p];
                            int elIndex = variable.PathVars.IndexOf(ex);
                            string v_Name = v.PathVars[v.PathVars.Count - 1];
                            name = tmpObj[v_Name];

                            
                            
                        }

                        Type type = name.GetType();
                        string res = name.ToString();
                        string tName = name.Type.ToString();

                        if (tName.Equals("Date"))
                        {
                            res = ValueConverter.ConvertDate(name.ToString());
                        }

                        if (tName.Equals("Float"))
                        {
                            res = ValueConverter.ConvertFloat(name.Value.ToString());
                        }
                        tmpResults.Add(res);
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
