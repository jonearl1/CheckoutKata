using CheckoutKata.src.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Repository
{
    class ItemRepository : IItemRepository
    {
        public Item getItem(string sku)
        {
            return (new Item(sku, 50));
        }
    }
}
