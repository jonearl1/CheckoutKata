using CheckoutKata.Repository;
using CheckoutKata.Service;
using NUnit.Framework;

namespace CheckoutKata.tests
{
    public class CheckoutTests
    {
        private ICheckout _checkout;
        [SetUp]
        public void Setup()
        {
            _checkout = new Checkout(new FileItemRepository());
        }

        [Test]
        public void SingleItemA()
        {
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(50, totalPrice);
        }

        [Test]
        public void SingleItemB()
        {
            _checkout.Scan("B");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(30, totalPrice);
        }
        [Test]
        public void SingleItemC()
        {
            _checkout.Scan("C");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(20, totalPrice);
        }
        [Test]
        public void SingleItemD()
        {
            _checkout.Scan("D");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(10, totalPrice);
        }


        [Test]
        public void MultipleItemsSameType()
        {
            _checkout.Scan("A");
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(100, totalPrice);
        }

        [Test]
        public void MultipleItemsDifferentType()
        {
            _checkout.Scan("A");
            _checkout.Scan("B");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(80, totalPrice);
        }

        [Test]
        public void DealItemA()
        {
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(130, totalPrice);
        }
    }
}