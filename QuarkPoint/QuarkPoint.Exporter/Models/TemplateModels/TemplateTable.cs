using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
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


        #endregion
    }
}
