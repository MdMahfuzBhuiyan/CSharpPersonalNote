// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample;

TrainingDbContext context = new TrainingDbContext();

//Student studnet1 = new Student
//{
//    Name = "azad",
//    Cgpa = 3.5,
//    DateOfBirth = new DateTime(1996, 2, 2)
//};

// Inserting one item
//context.Students.Add(studnet1);
//context.SaveChanges();

// Getting all data from table
List<Student> students = context.Students.ToList();

foreach (Student student in students)
    Console.WriteLine(student.Name);

// Getting items in different ways
var r1 = context.Students.Where(x => x.Name.Contains("abd")).ToList();
var r2 = context.Students.Where(x => x.Name.Contains("abd")).FirstOrDefault(); // no error
var r3 = context.Students.Where(x => x.Name.Contains("abd")).First(); // error when no record found
var r4 = context.Students.Where(x => x.Name.Contains("abd")).SingleOrDefault(); // error when more than 1 record found
var r5 = context.Students.Where(x => x.Name.Contains("abd")).Single(); // error when more than 1 or no record found
//var r6 = context.Students.Where(x => x.Name.Contains("aza")).LastOrDefault(); // opposite
//var r7 = context.Students.Where(x => x.Name.Contains("aza")).Last(); // opposite

// Edited one item
//r2.Name = "abdul";
//context.SaveChanges();

// Deleted one item
//r2 = context.Students.Where(x => x.Name.Contains("abd")).FirstOrDefault();
//context.Remove(r2);
//context.SaveChanges();

