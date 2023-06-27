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

    //checks if the number inputed is prime or not
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




namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
    //ask the user to assign a number 
    Console.WriteLine("Assign an int value to N: ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0;i<n;i++){
            
        for(int j =0;j<n;j++){

            //after user input, the console writes out how many # are needed
            Console.Write("#");
        }
            Console.WriteLine();
        }
  }
}




namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
int i,j,n;
Console.Write("Assign an int value to N: ");
n= int.Parse(Console.ReadLine());


for(i=1; i<=n; i++)


{
for(j=1; j<=i; j++)
{
Console.Write("*");
}
Console.Write("\n");
}
}
}

