
using Structure;

int x = 5;
int y = x;
x = 7;

string s = "hello";
string s2 = s;
s = "world";
Console.WriteLine(s);
Console.WriteLine(s2);

Console.WriteLine(x);
Console.WriteLine(y);

Console.WriteLine("--------------");

Person p1 = new Person { Name = "Jalaluddin", Age = 44 };
Person p2 = p1;
p1.Age = 45;

Console.WriteLine(p1.Age);
Console.WriteLine(p2.Age);

Print(p2);
void Print(Person p)
{

}

Person p3 = new Person();
Person p4 = p3;