using NUnit.Framework;
using System;
using CheckoutKata.Repository;
using CheckoutKata.Service;

namespace CheckoutKata
{
    public class CheckoutTests
    {
        private ICheckout _checkout;
        [SetUp]
        public void Setup()
        {
            _checkout = new Checkout(new FileRepository());
        }

        [Test]
        public void CheckoutTestItemA()
        {
            _checkout.Scan("A");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(50, totalPrice);
        }

        [Test]
        public void CheckoutTestItemB()
        {
            _checkout.Scan("B");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(30, totalPrice);
        }
        [Test]
        public void CheckoutTestItemC()
        {
            _checkout.Scan("C");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(20, totalPrice);
        }
        [Test]
        public void CheckoutTestItemD()
        {
            _checkout.Scan("D");
            int totalPrice = _checkout.GetTotalPrice();

            Assert.AreEqual(10, totalPrice);
        }
    }
}