// See https://aka.ms/new-console-template for more information
// 4.Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.

public static class Exercice
{
    public static void Main()
    {
        int number = 0;
        Console.WriteLine("First number is:");
        int number1=int.Parse(Console.ReadLine());

        Console.WriteLine("Second number is:");
        int number2=int.Parse(Console.ReadLine());

        int max=Math.Max(number1, number2);
        int min=Math.Min(number1, number2);
        for (int i =min; i <= max; i++) 
        {
            if (i % 5 == 0)
            {
                number++;
               
            }

        }
        Console.WriteLine("There are {0} numbers divisible with 5", number);
    }
}