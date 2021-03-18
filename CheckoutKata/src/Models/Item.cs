using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Models
{
    class Item
    {
        public Item(string sku, int cost)
        {
            Sku = sku;
            Cost = cost;
        }
        public string Sku { get; set; }
        public int Cost { get; set; }
    }
}
