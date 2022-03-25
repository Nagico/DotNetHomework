using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService;

        // 用户
        Customer alice;
        Customer bob;

        // 商品
        Product apple;
        Product banana;
        Product cheery;

        // 订单
        Order orderAlice;
        Order orderBob;
        Order orderAlice2;

        [TestInitialize]
        public void Init()
        {
            orderService = new OrderService();

            // 用户
            alice = new Customer(1, "Alice", "1234");
            bob = new Customer(2, "Bob", "12345");

            // 商品
            apple = new Product(1, "Apple", 2.0);
            banana = new Product(2, "Banana", 3.5);
            cheery = new Product(3, "Cherry", 4.25);

            // 添加订单
            orderAlice = orderService.Create(new Order(1, alice));
            orderAlice.AddOrderDetail(new OrderDetail(apple, 2, 1));
            orderAlice.AddOrderDetail(new OrderDetail(banana, 7, 0.65));
            orderAlice.AddOrderDetail(new OrderDetail(cheery, 3, 0.75));

            orderBob = orderService.Create(new Order(2, bob));
            orderBob.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
            orderBob.AddOrderDetail(new OrderDetail(cheery, 12, 0.9));

            orderAlice2 = orderService.Create(new Order(3, alice));
            orderAlice2.AddOrderDetail(new OrderDetail(cheery, 20, 0.6));
            orderAlice2.AddOrderDetail(new OrderDetail(apple, 25, 0.85));
        }

        [TestCleanup]
        public void Clean()
        {
            orderService.Delete(orderAlice);
            orderService.Delete(orderBob);
            orderService.Delete(orderAlice2);
        }
        [TestMethod()]
        public void CreateTest()
        {
            var order = orderService.Create(new Order(10, alice));
            Assert.IsNotNull(order);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateTestNull()
        {
            var order = orderService.Create(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTestDuplicate()
        {
            var order = orderService.Create(new Order(1, alice));
        }

        [TestMethod()]
        public void GetTest()
        {
            var test = orderService.Get(1);
            Assert.AreEqual(test, orderAlice);
        }

        [TestMethod()]
        public void GetTestNull()
        {
            var test = orderService.Get(10);
            Assert.IsNull(test);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var oldOrder = orderService.Get(1);
            var testOrder = new Order(1, alice);
            testOrder.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
            testOrder.AddOrderDetail(new OrderDetail(cheery, 12, 0.9));

            orderService.Update(testOrder);
            var neworder = orderService.Get(1);
            Assert.AreEqual(testOrder, neworder);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateTestNone()
        {
            var testOrder = new Order(10, alice);
            testOrder.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
            testOrder.AddOrderDetail(new OrderDetail(cheery, 12, 0.9));

            orderService.Update(testOrder);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateTestNull()
        {
            orderService.Update(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateOrUpdateTestNull()
        {
            orderService.CreateOrUpdate(null);
        }

        [TestMethod()]
        public void DeleteTestId()
        {
            orderService.Delete(1);
            Assert.IsNull(orderService.Get(1));
        }

        [TestMethod()]
        public void DeleteTestIdNone()
        {
            orderService.Delete(10);
            Assert.IsNull(orderService.Get(10));
        }

        [TestMethod()]
        public void DeleteTestObject()
        {
            orderService.Delete(orderAlice);
            Assert.IsNull(orderService.Get(1));
        }

        [TestMethod()]
        public void DeleteTestObjectNull()
        {
            orderService.Delete(null);
        }

        [TestMethod()]
        public void QueryTestLambda()
        {
            var test = orderService.QueryAll(o => o.Customer.Name == "Alice").ToList();
            CollectionAssert.AreEquivalent(test, new List<Order>() { orderAlice, orderAlice2 });
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QueryTestLambdaNull()
        {
            orderService.QueryAll(null);
        }

        [TestMethod()]
        public void ForEachTestLambda()
        {
            double test = 0;
            double sum = orderAlice.TotalPrice + orderAlice2.TotalPrice + orderBob.TotalPrice;
            orderService.ForEach(x => test += x.TotalPrice);
            Assert.AreEqual(test, sum);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ForEachTestLambdaNull()
        {
            orderService.ForEach(null);
        }

        [TestMethod()]
        public void OrderByTest()
        {
            var test = orderService.OrderBy(o => o.TotalPrice).First();
            Assert.AreEqual(test, orderAlice);
        }

        [TestMethod()]
        public void OrderByDescendingTest()
        {
            var test = orderService.OrderByDescending(o => o.TotalPrice).First();
            Assert.AreEqual(test, orderBob);
        }

        [TestMethod()]
        public void SerializationTest()
        {
            string filename = "test.xml";
            orderService.Export(filename);
            var orderService2 = new OrderService();
            orderService2.Import(filename);
            File.Delete(filename);
            CollectionAssert.AreEqual(orderService.QueryAll().ToList(), orderService2.QueryAll().ToList());
        }
    }
}