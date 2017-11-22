using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.AdditionalModels
{
    public class BalanceHeaderModel
    {
        #region constrcutor
        /// <summary>
        /// constructor
        /// </summary>
        public BalanceHeaderModel(string tableName)
        {
            try
            {
                TableName = tableName;
                Elements = new List<BalanceHeaderElement>();
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        #region fields
        /// <summary>
        /// table name
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// elements
        /// </summary>
        public List<BalanceHeaderElement> Elements { get; set; }


        #endregion


        #region methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void InitHeader(string name, string title)
        {
            try
            {
                Elements.Add(new BalanceHeaderElement(name,title));
            }
            catch (Exception e)
            {
                
            }
        }
        #endregion
    }
}
