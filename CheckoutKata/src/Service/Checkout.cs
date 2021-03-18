using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Models;
using CheckoutKata.Repository;

namespace CheckoutKata.Service
{
    class Checkout : ICheckout
    {
        private readonly IItemRepository _itemRepository;
        private readonly List<Item> _items = new List<Item>();

        public Checkout(IItemRepository itemRepository)
        {
            this._itemRepository = itemRepository;
        }
        int ICheckout.GetTotalPrice()
        {
            return _items.Sum(item => item.Price);
        }

        void ICheckout.Scan(string sku)
        {
            _items.Add(_itemRepository.GetItem(sku));
        }
    }
}
