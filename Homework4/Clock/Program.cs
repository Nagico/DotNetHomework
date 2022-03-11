using Clock;

Clock.Clock clock = new Clock.Clock();

void onTick(object sender, TickEventArgs args) // 订阅滴答事件
{
    Console.WriteLine($"Tick {args.Time}");
}

void onAlarm(object sender, AlarmEventArgs args) // 订阅响铃事件
{
    Console.WriteLine($"!! Alarm {args.Time}");
}

clock.OnTick += onTick;
clock.OnAlarm += onAlarm;

// 打开时钟
Console.WriteLine($"Set current time and start the clock at {DateTime.Now}");
clock.Time = DateTime.Now;
clock.Start();
Thread.Sleep(5000);

// 关闭时钟
Console.WriteLine($"Stop the clock at {DateTime.Now}");
clock.Stop();

Thread.Sleep(2000);

// 打开时钟
Console.WriteLine($"Set current time and start the clock at {DateTime.Now}");
clock.Time = DateTime.Now;
clock.Start();

Thread.Sleep(1500);

// 设定响铃
Console.WriteLine($"Turn on the alarm and set the alarm time at {DateTime.Now + TimeSpan.FromSeconds(5)}");
clock.AlarmTime = DateTime.Now + TimeSpan.FromSeconds(5);
clock.AlarmStatus = true;

Console.ReadKey();