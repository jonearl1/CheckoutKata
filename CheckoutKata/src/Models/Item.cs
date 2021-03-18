namespace CheckoutKata.Models
{
    class Item
    {
        public string Sku { get; set; }
        public int Price { get; set; }
        public Item(string sku, int price)
        {
            Sku = sku;
            Price = price;
        }
    }
}
