using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using QuarkPoint.Exporter.Models.ParseModels;
using QuarkPoint.Exporter.Models.TemplateModels.AdditionalTableModels;

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
                Columns = new List<ColumnModel>();
                IsInit = false;
                Formatting = new List<ReplaceModel>();
                DefaultCellStyle = new TemplateStyle()
                {
                    BackgroundColor = "#ffffff",
                    FontName = FontName.Times,
                    FontSize = 10,
                    FontWeight = FontWeight.Normal,
                    ForegroundColor = "#000000",
                    TextAlign = TextAlign.Center,
                    UnderLine =  false
                };
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


        /// <summary>
        /// default cell style
        /// </summary>
        [JsonProperty("default_style")]
        public TemplateStyle DefaultCellStyle { get; set; }

        /// <summary>
        /// formatting
        /// </summary>
        [JsonProperty("formatting")]

        public List<ReplaceModel> Formatting { get; set; }
        #endregion

        #region methods
        /// <summary>
        /// init columns
        /// </summary>
        public void InitColumns()
        {
            try
            {
                Columns = new List<ColumnModel>();
                for (int i = 0; i < ColumnsCount; i++)
                {
                    string name = "column " + i;

                    Columns.Add(new ColumnModel() {Index = i,Name = name});
                }
            }
            catch (Exception e)
            {
            }
        }


        /// <summary>
        /// init columns by vars
        /// </summary>
        /// <param name="columns"></param>
        public void InitColumnsWithVariable(List<ColumnEnabledModel> columns)
        {
            try
            {
                this.ColumnsCount = columns.Count;
                InitColumns();

                Rows = new List<RowModel>();
                RowModel model = new RowModel();
                model.Index = 0;
                int cIndex = 0;
                foreach (var column in columns)
                {
                    model.Cells.Add(new CellModel() {Index = cIndex, Name = column.Name,Value = column.Name});
                    cIndex++;
                }
                Rows.Add(model);

            }
            catch (Exception e)
            {
            }
        }
        #endregion


    }
}
