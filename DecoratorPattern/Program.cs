// See https://aka.ms/new-console-template for more information

using DecoratorPattern.Coffee;

Console.WriteLine("Hello, World!");

Coffee coffee = new Coffee(1.2,"Americano");
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
Milk milk = new Milk();
coffee.Add(milk);
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
coffee.Volume = Size.Grande;
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
Syrup syrup = new Syrup();
coffee.Add(syrup);
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
coffee.Volume = Size.Superiore;
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
coffee.Volume = Size.Superiore;
Console.WriteLine($"Your {coffee.GetDescription()} now costs ${coffee.GetPrice()}");
