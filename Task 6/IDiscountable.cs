using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public interface IDiscountable
    {
        decimal Discount { get; set; }
        decimal CalculateDiscountedPrice();
    }
}