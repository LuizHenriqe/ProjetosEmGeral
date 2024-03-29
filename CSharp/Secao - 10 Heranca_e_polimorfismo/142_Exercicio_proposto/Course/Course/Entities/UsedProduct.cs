﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class UsedProduct:Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name,double price,DateTime manufacture):base(name,price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag()
        {
            return $"{Name} (USED) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {Manufacture.ToString("dd/MM/yyyy")})";
        }
    }
}
