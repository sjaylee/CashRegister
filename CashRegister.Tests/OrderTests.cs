using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW.CashRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void GetInvoiceContent_NoneProduct_Test()
        {

            Order order = new Order();

            //case 1 : empty
            order.Products = null;

            var content = order.GetInvoiceContent();
            Assert.IsTrue(string.IsNullOrWhiteSpace(content));
        }


        [TestMethod()]
        public void GetInvoiceContent_ProductWithoutPromation_Test()
        {

            Order order = new Order();

            //case 1 : empty
            order.Products = new Dictionary<Product, int>();
            order.Products.Add(
                 new Product { BarCode = "ITEM000003", Category = "水果", Name = "苹果", Price = 5.5m, Unit = "斤" },
                 2);

            var content = order.GetInvoiceContent();
            Assert.AreEqual(@"***<没钱赚商店>购物清单***
名称：苹果，数量：2斤，单价：5.50(元)，小计：11.00(元)
----------------------
总计：11.00(元)
**********************", 
content);
        }

        [TestMethod()]
        public void GetInvoiceContent_ProductWithPromation95_Test()
        {

            Order order = new Order();

            //case 1 : empty
            order.Products = new Dictionary<Product, int>();
            order.Products.Add(
                 new Product { BarCode = "ITEM000003", Category = "水果", Name = "苹果", Price = 5.5m, Unit = "斤", Promation= new PromotionDiscount(0.95m) },
                 2);

            var content = order.GetInvoiceContent();
            Assert.AreEqual(@"***<没钱赚商店>购物清单***
名称：苹果，数量：2斤，单价：5.50(元)，小计：10.45(元)，节省0.55(元)
----------------------
总计：10.45(元)
节省：0.55(元)
**********************",
content);
        }

    }
}