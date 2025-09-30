// See https://aka.ms/new-console-template for more information
using Static;



var pi = Geometry.PI;
var area = Geometry.CalculateCircleArea(20);


// example 2

Counter counter1 = new Counter();
counter1.IncreaseCounter();

Counter counter2 = new Counter();
counter2.IncreaseCounter();

counter1.PrintCounter();
counter2.PrintCounter();

Console.WriteLine("Hello");
var line = Console.ReadLine();