using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuarkPoint.Exporter.Models.ParseModels;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    public class TemplateParagraph:TemplateStyle
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateParagraph()
        {
            try
            {
                Formatting = new List<ReplaceModel>();
            }
            catch (Exception e)
            {
            }    
        }
        #endregion

        #region fields
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// formatting
        /// </summary>
        [JsonProperty("formatting")]

        public List<ReplaceModel> Formatting { get; set; }
        #endregion
    }
}
