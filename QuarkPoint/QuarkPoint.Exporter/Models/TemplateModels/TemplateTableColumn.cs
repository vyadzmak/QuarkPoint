using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{

    /// <summary>
    /// column type
    /// </summary>
    public enum ColumnType { Text =0, Variable =1, Binding=2}
    

    public class TemplateTableColumn
    {
        #region constrcutor
        /// <summary>
        /// constrcutor
        /// </summary>
        public TemplateTableColumn()
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
        /// column type
        /// </summary>
        [JsonProperty("column_type")]
        public ColumnType ColumnType { get; set; }
        #endregion

    }
}
