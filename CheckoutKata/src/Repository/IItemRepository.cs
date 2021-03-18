using CheckoutKata.src.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Repository
{
    interface IItemRepository
    {
        public Item getItem(string sku);
    }
}
