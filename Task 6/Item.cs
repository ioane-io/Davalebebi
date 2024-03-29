﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual string GetProductInfo()
        {
            return $"{Name} {Price}";
        }
    }
}