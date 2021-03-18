using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src
{
    interface ICheckout
    {
        void Scan(string sku);
        int GetTotalPrice();
    }
}
