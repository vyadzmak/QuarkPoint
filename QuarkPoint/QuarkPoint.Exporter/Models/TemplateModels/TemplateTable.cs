using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// table type
    /// </summary>
    public enum TableType { SimpleByColumns =0, SimpleByHeaders =1}
    /// <summary>
    /// table
    /// </summary>
    public class TemplateTable
    {
        #region constructor

        /// <summary>
        /// constructor
        /// </summary>
        public TemplateTable()
        {
            try
            {
                IsInit = false;
                Headers = new List<TemplateTableHeader>();
                Footers = new List<TemplateTableFooter>();
                Columns = new List<TemplateTableColumn>();
                TableType = TableType.SimpleByColumns;
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        #region fields
        [JsonProperty("index")]

        public int Index { get; set; }

        [JsonProperty("headers")]
        public List<TemplateTableHeader> Headers { get; set; }

        [JsonProperty("footers")]
        public List<TemplateTableFooter> Footers { get; set; }


        /// <summary>
        /// is init?
        /// </summary>
        [JsonProperty("is_init")]
        public bool IsInit { get; set; }


        /// <summary>
        /// rows
        /// </summary>
        [JsonProperty("rows")]

        public List<TemplateTableRow> Rows { get; set; }

        /// <summary>
        /// table type
        /// </summary>
        [JsonProperty("table_type")]

        public TableType TableType { get; set; }

        /// <summary>
        /// columns
        /// </summary>
        [JsonProperty("columns")]
        public List<TemplateTableColumn> Columns { get; set; }
        #endregion
    }
}
