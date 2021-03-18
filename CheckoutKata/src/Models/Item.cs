using System.Collections.Generic;

namespace CheckoutKata.Models
{
    class Item
    {
        public string Sku { get; set; }
        public int Price { get; set; }

        public List<Deal> Deals { get; set; }

        public Item(string sku, int price, List<Deal> deals = null)
        {
            Sku = sku;
            Price = price;
            Deals = deals;
        }
    }
}
