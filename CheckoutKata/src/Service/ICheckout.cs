namespace CheckoutKata.Service
{
    interface ICheckout
    {
        void Scan(string sku);
        int GetTotalPrice();
    }
}
