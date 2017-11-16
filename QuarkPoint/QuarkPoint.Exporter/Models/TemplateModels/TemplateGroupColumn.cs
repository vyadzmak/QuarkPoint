using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.TemplateModels
{
    public class TemplateGroupColumn
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public TemplateGroupColumn()
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
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// columns
        /// </summary>
        public List<TemplateTableColumn> Columns { get; set; }
        #endregion
    }
}
