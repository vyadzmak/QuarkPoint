using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Opiu
{
    public class LoanType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class LoanContributionRow
    {
        public int Id { get; set; }

        public double LimitSum { get; set; }
        public double Principal { get; set; }
        public double Fee { get; set; }

        public string Name { get; set; }

        public double ForOpiu { get; set; }

        public LoanType LoanType { get; set; }
    }
    public class LoanContributionDetailsModel
    {
        public int Id { get; set; }
        public double TotalPrincipal { get; set; }

        public double TotalFee { get; set; }

        public double TotalForOpiu { get; set; }

        public List<LoanContributionRow> Rows { get; set; }
        public string Comments { get; set; }
    }
}
