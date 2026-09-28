using ConsoleApp_561.Models;

Student student = new Student
{
    Name = "Mariam",
    BirthDate = new DateOnly(2000, 5, 20)
};

student.Email = "mariam@example.com"; 
student.Email = "not-an-email";       

Student futureStudent = new Student
{
    BirthDate = DateOnly.FromDateTime(DateTime.Today.AddDays(1)) 
};

Console.WriteLine($"{student.Name} | {student.Email} | {student.BirthDate}");
