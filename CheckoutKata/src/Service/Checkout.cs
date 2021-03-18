using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
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
            return (from entry in _items let item = _itemRepository.GetItem(entry.Key) select item.Price * entry.Value).Sum();
        }
    }
}
