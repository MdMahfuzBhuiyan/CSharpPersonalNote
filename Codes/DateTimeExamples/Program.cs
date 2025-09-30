DateTime d1 = new DateTime(2002, 3, 30);
DateTime d2 = new DateTime(2003, 3, 23, 4, 30, 3, 33);

DateTime d3 = DateTime.Now;
DateTime d4 = DateTime.UtcNow;

DateTime d5 = d1.AddDays(-2);

Console.WriteLine(d5);
Console.WriteLine(d5.ToString("dd-MM-yyyy"));
Console.WriteLine(d5.ToShortDateString());
Console.WriteLine(d5.ToShortTimeString());

double dayGap = d2.Subtract(d1).TotalDays;
Console.WriteLine(dayGap);

Console.WriteLine(d1);

