using CheckoutKata.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CheckoutKata.Repository
{
    class FileItemRepository : IItemRepository
    {
        private readonly List<Item> _items;
        public FileItemRepository()
        {
            using StreamReader r = new StreamReader("resources//items.json");
            string json = r.ReadToEnd();
            _items = JsonConvert.DeserializeObject<List<Item>>(json);
        }
        public Item GetItem(string sku)
        {
            return _items.FirstOrDefault(item => item.Sku == sku);
        }
    }
}
