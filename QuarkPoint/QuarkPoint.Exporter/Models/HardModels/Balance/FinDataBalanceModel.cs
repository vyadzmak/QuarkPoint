using System;
using System.Collections.Generic;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    /// <summary>
    /// 
    /// </summary>
    public class FinDataBalanceModel
    {
        /// <summary>
        /// constructor
        /// </summary>
        public FinDataBalanceModel()
        {
            try
            {

            }
            catch (Exception e)
            {
            }
        }

        public List<CompanyModel> Companies { get; set; }

        public DateTime CurrentFinAnalysisDate { get; set; }

        public List<BalanceModel> Balances { get; set; }
    }
}
