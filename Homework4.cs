namespace Homework4;

using System;

public class Largest
{
    public static int largest(int n1, int n2)
    {

        //check if the first integer is larger
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static void Main(string[] args)
    {

        //ask user to enter integer
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());

        //prints which integer is the largest
        Console.WriteLine("The largest number is: " + largest(first, second));
    }
}
