using System.Collections.Generic;
using CheckoutKata.Models;
using CheckoutKata.Repository;

namespace CheckoutKata.Service
{
    class Checkout : ICheckout
    {
        private readonly IItemRepository _itemRepository;
        private readonly Dictionary<string, int> _items = new Dictionary<string, int>();

        public Checkout(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        void ICheckout.Scan(string sku)
        {
            if (_items.ContainsKey(sku))
            {
                _items[sku]++;
            }
            else
            {
                _items.Add(sku, 1);
            }
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach ((string entrySku, int entryCount) in _items)
            {
                int itemCount = entryCount;
                Item item = _itemRepository.GetItem(entrySku);

                if (item == null) continue;

                foreach (Deal deal in item.Deals)
                {
                    while (itemCount >= deal.Number)
                    {
                        itemCount -= deal.Number;
                        totalPrice += deal.Cost;
                    }
                }

                totalPrice += item.Price * itemCount;
            }

            return totalPrice;
        }
    }
}
