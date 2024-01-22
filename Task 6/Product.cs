using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Product : Item, IDiscountable
    {
        public ProductCategory Category { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Discount { get; set; }

        public Product(string name, decimal price, ProductCategory category, int quantityInStock, decimal discount)
        {
            Name = name;
            Price = price;
            Category = category;
            QuantityInStock = quantityInStock;
            Discount = discount;
        }

        public override string GetProductInfo()
        {
            return $" {base.GetProductInfo()} \n Category: {Category} \n Quantity in Stock: {QuantityInStock} \n Discount: {Discount}";
        }
        public decimal CalculateDiscountedPrice()
        {
            return Price - (Price * Discount);
        }
    }
}