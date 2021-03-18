using CheckoutKata.src;
using NUnit.Framework;

namespace CheckoutKata
{
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckoutTest()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan("A");
            int totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(totalPrice, 50);
        }
    }
}