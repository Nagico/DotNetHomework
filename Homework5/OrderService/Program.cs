using OrderService;

// 实例化 Service
var customerService = new CustomerService();
var productService = new ProductService();
var orderService = new OrderService.OrderService();

// 添加用户

Console.WriteLine(customerService.Add(new Customer("Alice")));
Console.WriteLine(customerService.Add(new Customer("Bob")));
Console.WriteLine(customerService.Add(new Customer("Carol")));
Console.WriteLine(customerService.Add(new Customer("Dave")));
Console.WriteLine(customerService.Add(new Customer("Dave")));  // 重名用户（不同 ID）

var eve = new Customer("Eve");
Console.WriteLine(customerService.Add(eve));

try
{
    Console.WriteLine(customerService.Add(eve));  // 重复添加
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// 添加商品

Console.WriteLine(productService.Add(new Product("Apple", 2.0)));
Console.WriteLine(productService.Add(new Product("Banana", 3.5)));
Console.WriteLine(productService.Add(new Product("Cherry", 4.25)));
Console.WriteLine(productService.Add(new Product("Durian", 1.8)));
Console.WriteLine(productService.Add(new Product("Durian", 1.9)));  // 重名商品（不同 ID）

var fig = new Product("fig", 10.0);
Console.WriteLine(productService.Add(fig));

try
{
    Console.WriteLine(productService.Add(fig));  // 重复添加
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


var alice = customerService.Query("Alice").First();
var bob = customerService.Query("Bob").First();
var carol = customerService.Query("Carol").First();
var dave = customerService.Get(5);
var apple = productService.Query("Apple").First();
var banana = productService.Query("Banana").First();
var cheery = productService.Query("Cherry").First();
var durian = productService.Get(4);

// 添加订单
var order = orderService.Add(new Order(alice));

order.AddOrderDetail(new OrderDetail(apple, 2, 1));
order.AddOrderDetail(new OrderDetail(banana, 7, 0.65));

order.AddOrderDetail(new OrderDetail(cheery, 3, 0.75));

try
{
    order.AddOrderDetail(new OrderDetail(cheery, 10, 0.8));
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message); // 重复添加
}

Console.WriteLine(order);

order = orderService.Add(new Order(bob));
order.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
order.AddOrderDetail(new OrderDetail(durian, 12, 0.9));

order = orderService.Add(new Order(carol));
order.AddOrderDetail(new OrderDetail(durian, 20, 0.6));
order.AddOrderDetail(new OrderDetail(apple, 25, 0.85));

// 查询订单
Console.WriteLine(orderService.Get(2));

Console.WriteLine();

Console.WriteLine(orderService.Query(totalPrice: 64.1).Count());

Console.WriteLine();

Console.WriteLine(orderService.Query(productName: "Banana").Count());

Console.WriteLine();

// 删除订单明细
order = orderService.Get(1);
order.DeleteOrderDetail(order.GetOrderDetail(apple));

Console.WriteLine(order);

Console.WriteLine();

// 排序
orderService.Sort();
orderService.ForEach(x => Console.WriteLine($"{x.Id}-{x.TotalPrice}"));

Console.WriteLine();

orderService.Sort((x, y) => Convert.ToInt32(y.TotalPrice - x.TotalPrice));
orderService.ForEach(x => Console.WriteLine($"{x.Id}-{x.TotalPrice}"));
