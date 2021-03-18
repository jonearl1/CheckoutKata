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

        [Test]
        public void DealItemB()
        {
            _checkout.Scan("B");
            _checkout.Scan("B");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(45, totalPrice);
        }

        [Test]
        public void DealDuplicateItemA()
        {
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(260, totalPrice);
        }

        [Test]
        public void DealItemAOverFlow()
        {
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(230, totalPrice);
        }

        [Test]
        public void DealItemsAb()
        {
            _checkout.Scan("B");
            _checkout.Scan("A");
            _checkout.Scan("B");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(95, totalPrice);
        }

        [Test]
        public void EmptyCheckout()
        {
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(0, totalPrice);
        }

        [Test]
        public void InvalidItemSku()
        {
            _checkout.Scan("E");
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(50, totalPrice);
        }
    }
}