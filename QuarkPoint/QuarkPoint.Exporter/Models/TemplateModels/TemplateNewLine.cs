using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    public class TemplateNewLine
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateNewLine()
        {
            try
            {

            }
            catch (Exception e)
            {
            }    
        }
        #endregion

        #region fields
        [JsonProperty("index")]
        public int Index { get; set; }

        
        #endregion
    }
}
