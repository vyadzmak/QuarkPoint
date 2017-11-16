using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// cell
    /// </summary>
    public class TemplateTableCell
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateTableCell()
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
        /// <summary>
        /// index
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// type
        /// </summary>
        [JsonProperty("column_type")]
        public ColumnType ColumnType { get; set; }
        #endregion
    }
}
