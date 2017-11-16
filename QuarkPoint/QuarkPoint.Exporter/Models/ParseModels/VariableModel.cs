using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.ParseModels
{
    /// <summary>
    /// variable model
    /// </summary>
    public class VariableModel
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public VariableModel(string name)
        {
            try
            {
                Name = name;
                PathVars = new List<string>();
            }
            catch (Exception e)
            {
            }
        }
        #endregion

        #region fields

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// path elements
        /// </summary>
        public List<string> PathVars { get; set; }
        #endregion

    }
}
