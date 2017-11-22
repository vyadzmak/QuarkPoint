using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.AdditionalModels
{
    public class BalanceHeaderElement
    {
        #region constructor
        /// <summary>
        /// constrcutor
        /// </summary>
        public BalanceHeaderElement(string name, string title)
        {
            try
            {
                Name = name;
                Title = title;
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
        /// title
        /// </summary>
        public string Title { get; set; }

        #endregion
    }
}
