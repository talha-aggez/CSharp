using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkDemo
{
    public class Product
    {
        public int ProductId { get; set; } //Primary KEy
        public int CategoryId { get; set; } // Foreign Key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
