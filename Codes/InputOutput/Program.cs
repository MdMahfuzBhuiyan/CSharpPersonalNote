
//Console.WriteLine("Hello");
//Console.WriteLine("World");

//Console.Write("From");
//Console.Write("C#");


//string line = Console.ReadLine();
//char c = (char)Console.Read();
//ConsoleKeyInfo key = Console.ReadKey();

//Console.WriteLine(key.KeyChar);


var nums = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    nums[i] = int.Parse(Console.ReadLine());
//}

string line = Console.ReadLine();

string[] words = line.Split(',', ' ');

int m = 0;
foreach (string word in words)
{
    nums[m++] = int.Parse(word.Trim());
}

Console.WriteLine();
