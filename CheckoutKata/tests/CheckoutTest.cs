using CheckoutKata.src;
using CheckoutKata.src.Repository;
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
            ICheckout checkout = new Checkout(new ItemRepository());
            checkout.Scan("A");
            int totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(totalPrice, 50);
        }
    }
}