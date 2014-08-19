using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Checkout.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        private Basket basket;

        [SetUp]
        public void Setup()
        {
            basket = new Basket();
        }

        [Test]
        public void EmptyBasketShouldHavePriceZero()
        {
            Assert.That(basket.Checkout(""), Is.EqualTo(0));
        }

        [Test]
        public void BasketWithOneAInCostsFifty()
        {
            //assert_equal( 50, price("A"))
            Assert.That(basket.Checkout("A"), Is.EqualTo(50));
        }

        [Test]
        public void BasketWithABCostsEighty()
        {
            Assert.That(basket.Checkout("AB"), Is.EqualTo(80));
        }

        [Test]
        public void BasketWithCDBACosts115()
        {
            //assert_equal(115, price("CDBA"))
            Assert.That(basket.Checkout("CDBA"), Is.EqualTo(115));
        }

        [Test]
        public void BasketWithAACosts100()
        {
            Assert.That(basket.Checkout("AA"), Is.EqualTo(100));
        }

        [Test]
        public void BasketWithAAACost130()
        {
            Assert.That(basket.Checkout("AAA"), Is.EqualTo(130));
        }

        [Test]
        public void BasketWithAAAACost180()
        {
            //assert_equal(180, price("AAAA"))
            Assert.That(basket.Checkout("AAAA"), Is.EqualTo(180));
        }

        [Test]
        public void BasketWithAAAAACost230()
        {

            Assert.That(basket.Checkout("AAAAA"), Is.EqualTo(230));
        }

        [Test]
        public void BasketWithAAAAAACost260()
        {

            Assert.That(basket.Checkout("AAAAAA"), Is.EqualTo(260));
        }

        [Test]
        public void BasketWithAAABCost160()
        {

            Assert.That(basket.Checkout("AAAB"), Is.EqualTo(160));
        }

        [Test]
        public void BasketWithAAABBCost175()
        {

            Assert.That(basket.Checkout("AAABB"), Is.EqualTo(175));
        }

        [Test]
        public void BasketWithAAABBDCosts190()
        {
            Assert.That(basket.Checkout("AAABBD"), Is.EqualTo(190));
        }

        [Test]
        public void BasketWithDABABACosts190()
        {
            Assert.That(basket.Checkout("DABABA"), Is.EqualTo(190));
        }
    }
}
