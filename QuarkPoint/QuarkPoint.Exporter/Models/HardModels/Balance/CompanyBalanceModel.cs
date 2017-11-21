using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    public class CompanyBalanceModel
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public DateTime Date { get; set; }

        public AssetsModel Assets { get; set; }

        public LiabilityModel Liabilities { get; set; }

        public double LiquidAssets { get; set; }
        public double Receivables { get; set; }
        public double Inventories { get; set; }
        public double TotalCurrentAssets { get; set; }
        public double TotalFixedAssets { get; set; }
        public double TotalAssets { get; set; }
        public double TotalShortTermDebt { get; set; }
        public double TotalLongTermDebt { get; set; }
        public double TotalLongAccountsPayable { get; set; }
        public double Equity { get; set; }
        public double TotalLiabilities { get; set; }
        public double OutLiquidAssets { get; set; }
        public double OutReceivables { get; set; }
        public double OutInventories { get; set; }
        public double OutTotalCurrentAssets { get; set; }
        public double OutTotalFixedAssets { get; set; }
        public double OutTotalAssets { get; set; }
        public double OutTotalShortTermDebt { get; set; }
        public double OutTotalLongTermDebt { get; set; }
        public double OutTotalLongAccountsPayable { get; set; }
        public double OutEquity { get; set; }
        public double OutTotalLiabilities { get; set; }

        public double ConsLiquidAssets { get; set; }
        public double ConsReceivables { get; set; }
        public double ConsInventories { get; set; }
        public double ConsTotalCurrentAssets { get; set; }
        public double ConsTotalFixedAssets { get; set; }
        public double ConsTotalAssets { get; set; }
        public double ConsTotalShortTermDebt { get; set; }
        public double ConsTotalLongTermDebt { get; set; }
        public double ConsTotalLongAccountsPayable { get; set; }
        public double ConsEquity { get; set; }
        public double ConsTotalLiabilities { get; set; }
    }
}
