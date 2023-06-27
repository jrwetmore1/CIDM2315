namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //ask user to enter a number
        Console.Write("Input an integer:");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        //message back to the user after a number is entered
        if (isPrime)
            Console.WriteLine($"{number} is prime.");
        else
            Console.WriteLine($"{number} is non-prime.");
    }

    //checks if the number inputed is a prime or not
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
                break;
            }
        }

        return true;
    }
}
