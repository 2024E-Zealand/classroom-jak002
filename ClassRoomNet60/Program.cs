// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

ClassRoom dat3b = new ClassRoom();
dat3b.ClassName = "3B";
dat3b.SemesterStart = new(2024, 8, 26);
try
{
    dat3b.StudentList = new List<Student>() { new("Jacob", 1, 30), new("Marius", 12, 5), new("Stephane", 9, 3), new("shhh", 14, 14) };
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    dat3b.StudentList = new();
}
Console.WriteLine("Classroom name: " + dat3b.ClassName);
Console.WriteLine("Semester start: " + dat3b.SemesterStart.ToShortDateString());
Console.WriteLine("Students:");
foreach(Student student in dat3b.StudentList) 
{
    Console.WriteLine($"\t {student.Name}, born {student.Birthday}/{student.BirthMonth}");
}

dat3b.SeasonSum();