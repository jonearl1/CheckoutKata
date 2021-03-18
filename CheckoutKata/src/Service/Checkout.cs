using CheckoutKata.src.Models;
using CheckoutKata.src.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src
{
    class Checkout : ICheckout
    {
        IItemRepository itemRepository;
        List<Item> items = new List<Item>();

        public Checkout(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        int ICheckout.GetTotalPrice()
        {
            int totalPrice = 0;
            foreach( Item item in items)
            {
                totalPrice += item.Cost;
            }
            return totalPrice;
        }

        void ICheckout.Scan(string sku)
        {
            items.Add(itemRepository.getItem(sku));
        }
    }
}
