using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Opiu
{
    public class OpiuModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BalanceData { get; set; }

        public int OpiuMonthsQuantity { get; set; }

        public List<OpiuMonthModel> Months { get; set; }

        public List<dynamic> Table { get; set; }
    }
}
