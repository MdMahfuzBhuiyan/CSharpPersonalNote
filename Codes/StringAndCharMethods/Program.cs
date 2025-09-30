
string s = "Hello";
char c = 'a';

if(s.EndsWith("lo"))
{
    s.Insert(3, "b");
}

Console.WriteLine(s.Insert(3, "b"));

Console.WriteLine(s.PadLeft(10, '*'));

Console.WriteLine(s.Remove(3, 2));

Console.WriteLine(s.Replace("ll", "dd"));

// 2 version of empty strings
string m = "";
string m2 = string.Empty;
string m3 = "   ";
string m4 = "\t";
string m5 = null;

string.IsNullOrEmpty(s);
string.IsNullOrWhiteSpace(s);

if(s is not null || s == string.Empty)
{

}

if(string.IsNullOrWhiteSpace(s))
{

}

Console.WriteLine(char.IsDigit(c));
Console.WriteLine(char.ToUpper(c));