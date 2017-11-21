using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    public class BalanceElement
    {
        public double Total { get; set; }

        public double OutTotal { get; set; }

        public double ConsTotal { get; set; }

        public List<object> Rows { get; set; }
    }
}
