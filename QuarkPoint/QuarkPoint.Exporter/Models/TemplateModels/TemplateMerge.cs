using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    /// <summary>
    /// direction
    /// </summary>
    public enum MergeDirection { Horizontal =0, Vertical = 1}
    public class TemplateMerge
    {

        #region constructor
        /// <summary>
        /// constrcutor
        /// </summary>
        public TemplateMerge()
        {
            try
            {
                StartIndex = -1;
                EndIndex = -1;
                Direction = MergeDirection.Horizontal;
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region fields
        /// <summary>
        /// start index
        /// </summary>
        [JsonProperty("start_index")]

        public int StartIndex { get; set; }

        /// <summary>
        /// end index
        /// </summary>
        [JsonProperty("end_index")]

        public int EndIndex { get; set; }

        /// <summary>
        /// direction
        /// </summary>
        [JsonProperty("direction")]

        public MergeDirection Direction { get; set; }
        #endregion

    }
}
