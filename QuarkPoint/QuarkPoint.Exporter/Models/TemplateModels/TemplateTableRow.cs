using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// row
    /// </summary>
    public class TemplateTableRow
    {
        #region constructor
        /// <summary>
        /// constrcutor
        /// </summary>
        public TemplateTableRow()
        {
            try
            {
                Cells = new List<TemplateTableCell>();
            }
            catch (Exception e)
            {
            }    
        }
        #endregion

        #region fields
        /// <summary>
        /// index
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }
        /// <summary>
        /// cells
        /// </summary>
        [JsonProperty("cells")]
        public List<TemplateTableCell> Cells { get; set; }

        /// <summary>
        /// merges
        /// </summary>
        [JsonProperty("merges")]
        public List<TemplateMerge> Merges { get; set; }
        #endregion
    }
}
