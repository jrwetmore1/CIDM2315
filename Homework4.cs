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








namespace Homework4;

using System;

public class Largest
{
    //checks which integer is the largest
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
    
    public static void Main(string[] args)
    {
        //ask user to enter four integers
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        int fourth = Convert.ToInt32(Console.ReadLine());

        //prints the largest integer
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}







namespace Homework4;

using System;

class Program
{
static void Main()
{
createAccount();
}
public static bool checkAge(int birth_year)
{
if ((2022 - birth_year) >= 18)
return true;
else
return false;
}
public static void createAccount()
{
Console.Write("Enter the userName: ");
string userName = Console.ReadLine();
Console.Write("Enter the password: ");
string password = Console.ReadLine();
Console.Write("Enter the password again: ");
string confirm_password = Console.ReadLine();
Console.Write("Enter the birth year: ");
int birth_year = Convert.ToInt32(Console.ReadLine());
if (checkAge(birth_year))
{
if (password==confirm_password)
Console.WriteLine("Account is created Successfully.");
else
Console.WriteLine("Wrong Password.");

}
else
{
Console.WriteLine("Could not create an account.");
}
}
}



