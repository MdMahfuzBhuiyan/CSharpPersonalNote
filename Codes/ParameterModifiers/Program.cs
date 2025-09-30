using ParameterModifiers;

Console.WriteLine();

Calculator calculator = new Calculator();
int r = calculator.Sum(new int[] { 2, 3, 5, 5 });
int r2 = calculator.Sum(2, 3, 5, 5);


//var sql = "insert int users(id, name, age, gender, dateofBirth) values(@id, @name, @age, @gender, @dateOfBirth)";
//int id;
//string name;
//int age;
//bool gender;
//DateTime dateOfBirth;
//ExcuteSql(sql, id, name, age, gender, dateOfBirth);

Person s = new Person();
s.IncreaseAge();
calculator.InsertValue2(out s);
Console.WriteLine(s.Age);

Person p = new Person();
p.IncreaseAge();
calculator.InsertValue3(ref p);
Console.WriteLine(p.Age);