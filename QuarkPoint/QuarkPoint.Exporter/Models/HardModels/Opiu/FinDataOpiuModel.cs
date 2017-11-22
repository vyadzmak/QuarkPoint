using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Opiu
{
    public class FinDataOpiuModel
    {
        public List<FinDataOpiuCompanyModel> Companies { get; set; }

        public List<OpiuModel> Opius { get; set; }
    }
}
