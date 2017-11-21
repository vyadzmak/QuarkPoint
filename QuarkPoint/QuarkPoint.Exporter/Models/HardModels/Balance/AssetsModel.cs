using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkPoint.Exporter.Models.HardModels.Balance
{
    public class AssetsModel
    {
        public BalanceElement Checkout { get; set; }
        public BalanceElement CurrentAccount { get; set; }
        public BalanceElement Savings { get; set; }
        public BalanceElement Deposit { get; set; }
        public BalanceElement Recievables { get; set; }
        public BalanceElement OtherRecievables { get; set; }
        public BalanceElement Inventories { get; set; }
        public BalanceElement Hardware { get; set; }
        public BalanceElement MotorTransport { get; set; }
        public BalanceElement RealEstate { get; set; }
        public BalanceElement Investments { get; set; }
        public BalanceElement TransitGoods { get; set; }
        public BalanceElement SuppliersPrepayment { get; set; }
        public BalanceElement ForSaleGoods { get; set; }
    }
}
