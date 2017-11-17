using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels.TableModels
{
    public class RowModel
    {
        #region constructor
        /// <summary>
        /// row model
        /// </summary>
        public RowModel()
        {
            try
            {
                Cells = new List<CellModel>();
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

        public List<CellModel> Cells { get; set; }

        #endregion
    }
}
