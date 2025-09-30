using OOP.Basic;
using OOPBasics;
using OOPHelper;

Car car1 = new Car("red", 200);
car1.Start();

Car car2 = new Car();
car2.Start();

double m = car1.MaxSpeed;



CreateProducts();
GC.Collect();
GC.WaitForPendingFinalizers();


void CreateProducts()
{
    Product p1 = new Product();
    Product p2 = new Product();
    Console.WriteLine("Products created");
}


Product p = new Burger();
p.Name = "Test1";
Burger b = new Burger();
b.Name = "Test2";

p.CalculateDiscount(20);

p.PrintName();
b.PrintName();

// Can't access internal class from OOPHelper project
//Box box = new Box();
//box.Width = 20;
//box.Height = 30;