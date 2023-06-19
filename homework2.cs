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







namespace Lecture2;

class Program
{
    static void Main(string[] args)
    {

        //ask user to enter in number
        Console.WriteLine("Input three numbers:");

        //next 3 console asks questions
        Console.Write("Please input the first num: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second num: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third num: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        //code to see which number is the smallest
        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }

        //lets the user know which number is the smallest
        Console.WriteLine("The smallest value is: " + smallest);
    }
}
