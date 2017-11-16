using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuarkPoint.Tester.Helpers.ReuestHelpers
{
    public static class RequestHelper
    {
        /// <summary>
        /// get request
        /// </summary>
        /// <returns></returns>
        public static string GetRequest()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.QueryString.Add("id", Program.MainForm.CurrentProjectId.ToString());
                
                string result = webClient.DownloadString("http://localhost/BlitzApi/api/projects");
                
                return result;
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
