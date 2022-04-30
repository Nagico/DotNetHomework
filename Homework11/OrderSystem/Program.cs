using OrderSystem.models;
using OrderSystem.services;

// 实例化 Service
var orderService = new OrderService();

// 用户
var alice = new Customer(1, "Alice", "1234");
var bob = new Customer(2, "Bob", "12345");

// 商品
var apple = new Product(1, "Apple", 2.0);
var banana = new Product(2, "Banana", 3.5);
var cheery = new Product(3, "Cherry", 4.25);

// 添加订单
var order_alice = new Order(4, alice);
order_alice.AddOrderDetail(new OrderDetail(apple, 2, 1));
order_alice.AddOrderDetail(new OrderDetail(banana, 7, 0.65));
order_alice.AddOrderDetail(new OrderDetail(cheery, 3, 0.75));
orderService.Create(order_alice);

var order_bob = new Order(5, bob);
order_bob.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
order_bob.AddOrderDetail(new OrderDetail(cheery, 12, 0.9));
orderService.Create(order_bob);

var order_carol = new Order(6, alice);
order_carol.AddOrderDetail(new OrderDetail(cheery, 20, 0.6));
order_carol.AddOrderDetail(new OrderDetail(apple, 25, 0.85));
orderService.Create(order_carol);


orderService.ForEach(x => Console.WriteLine($"Order:{x.Id} TotalPrice:{x.TotalPrice}"));
