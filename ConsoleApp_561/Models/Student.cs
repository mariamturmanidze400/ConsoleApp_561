using ConsoleApp_561.Validators;

namespace ConsoleApp_561.Models;

internal class Student
{
    private string name = string.Empty; // field
    private string email = string.Empty;
    private DateOnly birthDate;

    public string Name
    {
        get => name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name cannot be null or whitespace!");
            }
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (StudentValidator.IsValidEmail(value))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Invalid email format!");
            }
        }
    }

    public DateOnly BirthDate
    {
        get => birthDate;
        init
        {
            if (StudentValidator.IsValidBirthDate(value))
            {
                birthDate = value;
            }
            else
            {
                Console.WriteLine("Birth date cannot be in the future!");
            }
        }
    }

    //Id(int)
    //Grade(enum: A, B, C, D, F) 
}
