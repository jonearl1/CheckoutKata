﻿using System;
using CheckoutKata.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework.Constraints;

namespace CheckoutKata.Repository
{
    class FileRepository : IItemRepository
    {
        private List<Item> _items;
        public FileRepository()
        {
            using StreamReader r = new StreamReader("resources//items.json");
            string json = r.ReadToEnd();
            _items = JsonConvert.DeserializeObject<List<Item>>(json);
        }
        public Item GetItem(string sku)
        {
            Item item = _items.FirstOrDefault(item => item.Sku == sku);
            Console.WriteLine(item.Sku);
            Console.WriteLine(item.Price);
            return item;
        }
    }
}