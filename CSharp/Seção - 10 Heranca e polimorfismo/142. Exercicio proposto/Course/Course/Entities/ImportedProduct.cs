using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double CustomsFee) : base(name, price)
        {
            this.CustomsFee = CustomsFee;
        }

        public double TotalPrice()
        {
            return Price+CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + $" (Customs fee: $ {CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }
    }
}
