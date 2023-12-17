using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class DiscountedProduct : Product
    {
        public DiscountedProduct(string name, decimal price, ProductCategory category, int quantityInStock, decimal discount)
       : base(name, price, category, quantityInStock, discount)
        {
        }
        public override string GetProductInfo()
        {
            return $"Discounted {base.GetProductInfo()}";
        }
    }
}