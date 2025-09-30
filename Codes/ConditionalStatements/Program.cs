
int x = 5;

if(x < 10)
{
    x += 10;
}
else if(x > 6 && x < 10)
{
    x -= 6;
}
else if (x > 8 && x < 20)
{
    x /= 20;
}
else if (x >0 && x < 5)
{
    x *= 5;
}
else
{
    Console.WriteLine(x);
}


int y = 5;
switch(x)
{
    case 0:
        x += 1;
        break;
    case 1:
        x += 2;
        break;
    default:
        x += 0;
        break;
}

string name = "dhaka";
switch(name)
{
    case "dhaka":
        Console.WriteLine("capital");
        break;
    case "chittagong":
        Console.WriteLine("port");
        break;
    default:
        break;
}


int distance = (name == "dhaka" ? 430 : 100);