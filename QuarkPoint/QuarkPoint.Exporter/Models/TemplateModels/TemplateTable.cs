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
    public enum TableType { DataByVariables =0, DataByArray =1, ComplexDataByArray =2}
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
                Rows = new List<TemplateTableRow>();
                TableType = TableType.DataByVariables;
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
        /// groups
        /// </summary>
        [JsonProperty("groups")]

        public List<TemplateGroupColumn> Groups { get; set; }

        /// <summary>
        /// group count
        /// </summary>
        [JsonProperty("group_count")]
        public int GroupCount { get; set; }

        /// <summary>
        /// group size
        /// </summary>
        [JsonProperty("group_size")]
        
        public int GroupSize { get; set; }

        /// <summary>
        /// columns
        /// </summary>
        [JsonProperty("columns_count")]
        public int ColumnsCount { get; set; }
        #endregion


        #region method
        /// <summary>
        /// init groups
        /// </summary>
        public void InitGroups()
        {
            try
            {
                for (int i = 0; i < GroupCount; i++)
                {
                    TemplateGroupColumn group = new TemplateGroupColumn();
                    group.Name = "group " + (i + 1).ToString();
                    for (int j = 0; j < GroupSize; j++)
                    {
                        TemplateTableColumn column =new TemplateTableColumn();
                        column.Name = "column " + (j + 1).ToString();
                        group.Columns.Add(column);
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// int columns
        /// </summary>
        public void InitColumns()
        {
            try
            {
                for (int i = 0; i < ColumnsCount; i++)
                {
                    Columns.Add(new TemplateTableColumn() {ColumnType = ColumnType.Text, Index=i,Name = "column "+(i+1).ToString()});
                }
            }
            catch (Exception e)
            {
            }
        }
        #endregion


    }
}
