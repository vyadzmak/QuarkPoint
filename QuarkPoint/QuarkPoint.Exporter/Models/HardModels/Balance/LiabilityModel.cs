using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    public class LiabilityModel
    {
        public BalanceElement PayableAccounts { get; set; }
        public BalanceElement ShortPrivateLoans { get; set; }
        public BalanceElement ShortCredit { get; set; }
        public BalanceElement OtherCurrentDebt { get; set; }
        public BalanceElement LongPrivateLoans { get; set; }
        public BalanceElement LongCredit { get; set; }
        public BalanceElement OtherLiabilities { get; set; }
        public BalanceElement BudgetSettlement { get; set; }
        public BalanceElement RentalsArrears { get; set; }
        public BalanceElement ShortTermDebt { get; set; }
        public BalanceElement CommodityLoan { get; set; }
        public BalanceElement CustomersPrepayment { get; set; }
        public BalanceElement ShortFixedAssetsCredit { get; set; }
        public BalanceElement LongFixedAssetsCredit { get; set; }
        

    }
}
