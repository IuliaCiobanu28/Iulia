// See https://aka.ms/new-console-template for more information
//Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)0
using System.Diagnostics.CodeAnalysis;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Entre five numbers:");
        int number, sum = 0;
        for (int i = 1; i <= 5;i++)
        {
            Console.Write("number{0}=",i);
      
            bool isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber == false)
            {
                Console.Write("Try Again. Number{0}=",i);
              number = int.Parse(Console.ReadLine());
            }
             sum = sum + number;
        }
      
        Console.WriteLine("The sum of the five numbers is {0}",sum);
    }
}