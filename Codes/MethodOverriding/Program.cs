
using MethodOverriding;
Console.WriteLine("==Numbers==\n");
Numbers numbers = new Numbers();
numbers.NumberItems = [5, 9, 7, 4, 8];
numbers.Print(7);

Console.WriteLine("==Modified Numbers==\n");
Numbers modifiedNumbers = new ModifiedNumbers();
modifiedNumbers.NumberItems = [5, 9, 7, 4, 8];
modifiedNumbers.Print(7);