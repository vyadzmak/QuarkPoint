using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    public class BalanceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }

        public List<CompanyBalanceModel> CompanyBalances { get; set; }

        //coefficients

        public string Comments { get; set; }
        
        public double UrgentLiquidityCoef { get;set;}
        public double CurrentLiquidityCoef { get;set;}
        public double NetWorkingCapital { get;set;}
        public double OperationCycle { get;set;}
        public double FinancialCycle { get;set;}
        public double GrossProfitability { get;set;}
        public double NetProfitability { get;set;}
        public double ProfitabilityBeforeTaxes { get;set;}
        public double CoverageRate { get;set;}
        public double ROE { get;set;}
        public double ROA{ get;set;}
        public double DebtAssetsRatio { get;set;}
        public double AutonomyCoef { get;set;}
        public double TurnoverSpeedCoef { get;set;}
        public double TurnoverInventoryCoef { get;set;}
        public double Equity1Coef { get;set;}

        public double DebtorsTurnoverTerm { get; set; }
        public double InventoriesTurnoverTerm { get; set; }
        public double CreditorsTurnoverTerm { get; set; }
    }
}
