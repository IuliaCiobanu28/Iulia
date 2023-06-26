// See https://aka.ms/new-console-template for more information
//5.Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.

using System.ComponentModel.Design;

public static class GreaterNumber
{
    public static void Main()
    {
        //without conditional statements
        Console.Write("First number is:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Second number is:");
        int number2 = int.Parse(Console.ReadLine());

        int max = Math.Max(number1, number2);
        Console.WriteLine("The greater number is:" + max);

        //with conditional statements

        if (number1 > number2)
        
            Console.WriteLine("The greater number is" + number1);
        else
            {
                if (number1 == number2)
                    Console.WriteLine("The numbers are equal");
                else
                    Console.WriteLine("The greater number is" + number2);
            }
        

        
    }
}