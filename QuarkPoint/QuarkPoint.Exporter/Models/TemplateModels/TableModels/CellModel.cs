using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels.TableModels
{
    /// <summary>
    /// cell model
    /// </summary>
    public class CellModel
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public CellModel()
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
        /// value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        #endregion
    }
}
