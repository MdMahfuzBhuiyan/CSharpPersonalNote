

int x = 5;
int y = x + 5;
int z = y - 5;
int w = x * 5;
int v = y / 5;
int t = z % 2;

x++; // x = x + 1
++x; // x = x + 1
y--; // y = y - 1
--y; // y = y - 1


int m1 = 5;
int t1 = m1++;

int m2 = 5;
int t2 = ++m2;

Console.WriteLine(t1);
Console.WriteLine(t2);

z += 2; // z = z + 2;
z -= 2;
z *= 2;
z /= 2;
z %= 2;


bool a = (x == y);
bool b = (y < z);
bool c = (y > z);
bool d = (y >= z);
bool e = (y <= z);

bool f = !a;


bool g = a && b;  bool r = (x + y % 2 == 0) && (z > 5);
bool h = a || b;


int s = 0b_101_110_101;

s = s >> 2; // 101_110_1

Console.WriteLine(Convert.ToString(s, toBase: 2));



int sm = 0b_110_101;
int sn = 0b_011_010;

int st = sm & sn; //   010_000
int ss = sm | sn; //   111_111
int sr = sm ^ sn; //   101_111

Console.WriteLine(Convert.ToString(st, toBase: 2));
Console.WriteLine(Convert.ToString(ss, toBase: 2));
Console.WriteLine(Convert.ToString(sr, toBase: 2));

