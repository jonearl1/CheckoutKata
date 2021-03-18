using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src
{
    class Checkout : ICheckout
    {
        int ICheckout.GetTotalPrice()
        {
            return 0;
        }

        void ICheckout.Scan(string sku)
        {
        }
    }
}
