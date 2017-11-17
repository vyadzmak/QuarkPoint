using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QuarkPoint.Exporter.Models.TemplateModels.TableModels
{
    /// <summary>
    /// data type
    /// </summary>
    public enum DataType { Manual=0, AutoByDataWithoutFormatting=1, AutoByDataWithFormatting =2}
    public class TableModel
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TableModel()
        {
            try
            {
                DataType = DataType.Manual;
                UseHeaders = false;
                UseFooters = false;
                Rows = new List<RowModel>();
                IsInit = false;
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
        /// headers
        /// </summary>
        [JsonProperty("headers")]

        public List<HeaderModel> Headers { get; set; }

        /// <summary>
        /// footers
        /// </summary>
        [JsonProperty("footers")]

        public List<HeaderModel> Footers { get; set; }

        /// <summary>
        /// rows
        /// </summary>
        [JsonProperty("rows")]

        public List<RowModel> Rows { get; set; }

        /// <summary>
        /// is init?
        /// </summary>
        [JsonProperty("is_init")]
        public bool IsInit { get; set; }

        /// <summary>
        /// use headers
        /// </summary>
        [JsonProperty("use_headers")]
        public bool UseHeaders { get; set; }

        /// <summary>
        /// use footers
        /// </summary>
        [JsonProperty("use_footers")]

        public bool UseFooters { get; set; }

        /// <summary>
        /// columns count
        /// </summary>
        [JsonProperty("columns_count")]

        public int ColumnsCount { get; set; }

        /// <summary>
        /// table data
        /// </summary>
        [JsonProperty("data_type")]
        public DataType DataType { get; set; }

        /// <summary>
        /// data source
        /// </summary>
        [JsonProperty("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// columns
        /// </summary>
        [JsonProperty("columns")]
        public List<ColumnModel> Columns { get; set; }
        #endregion
    }
}
