using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.ParseModels
{
    public class ReplaceModel
    {
        #region constructor
        /// <summary>
        /// constrcutor
        /// </summary>
        public ReplaceModel()
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
        /// from
        /// </summary>
        public string From { get; set; }

        public string To { get; set; }
        #endregion

    }
}
