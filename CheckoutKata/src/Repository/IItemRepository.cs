using CheckoutKata.Models;

namespace CheckoutKata.Repository
{
    interface IItemRepository
    {
        public Item GetItem(string sku);
    }
}
