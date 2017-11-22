using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;

namespace QuarkPoint.Exporter.Models.HardModels.Odds
{
    public class OddsModel
    {
        public List<OddsHeader> Header { get; set; }

        public List<object> Table { get; set; }
    }
}
