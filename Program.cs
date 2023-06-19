namespace Lecture2;

class Program
{
    static void Main(string[] args)
    {
        //the question asked in the terminal
        Console.Write("Enter the grade letter: ");

        //input from user
        string grade = Console.ReadLine();

        int gpa_points;

        //changes lowercase letters to uppercase
        switch (grade.ToUpper())
        {
         case "A":
        gpa_points = 4;
        break;
         case "B":
        gpa_points = 3;
        break;
        case "C":
        gpa_points = 2;
        break;
        case "D":
        gpa_points = 1;
        break;
        case "F":
        gpa_points = 0;
        break;
        default:
        Console.WriteLine("Wrong Letter Grade!");
        return;
        }

        //correct letter returns this statement
        Console.WriteLine($"GPA point: {gpa_points}");
    }
}
