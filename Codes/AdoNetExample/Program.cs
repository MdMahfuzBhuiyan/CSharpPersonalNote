
using AdoNetExample;

var connectionString = "Server=DESKTOP-JEEVIUV\\SQLEXPRESS;Database=CSharpB21;User Id=csharpb21;Password=123456;Trust Server Certificate=true";
var sqlUtility = new SqlUtility(connectionString);

var sql = "insert into Students ([Name], Cgpa, dateofbirth) values('Abdul', 3.39, '1/1/2001');";

//sqlUtility.ExecuteSqlCommand(sql);

Console.WriteLine("Complete");

var query = "select name,cgpa from Students where cgpa > 3.0";
var data = sqlUtility.ExecuteSqlQuery(query);

foreach (var item in data)
{
    foreach(var key in item.Keys)
    {
        Console.Write($"{key}: {item[key]} ");
    }
    Console.WriteLine();
}
