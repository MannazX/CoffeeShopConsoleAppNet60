// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, Coffee Shop!");
Console.WriteLine();

List<Coffee> coffeeList = new List<Coffee>();

coffeeList.Add(new BlackCoffee(2.5));
coffeeList.Add(new Cortado(3));
coffeeList.Add(new Latte(5));
coffeeList.Add(new BlackCoffee(2.5));
coffeeList.Add(new Cortado(3));
coffeeList.Add(new Latte(5));

foreach (Coffee coffee in coffeeList)
{
	Console.WriteLine($"Price: {coffee.PriceOfCoffee()}, Strength: {coffee.Strength()}");
}

List<Coffee> milkCoffees = new List<Coffee>();

milkCoffees.Add(new Cortado(3));
milkCoffees.Add(new Latte(5));
milkCoffees.Add(new Cortado(3));
milkCoffees.Add(new Latte(5));

