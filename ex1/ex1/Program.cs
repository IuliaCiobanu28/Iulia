

//1.Write a program that reads from the console 3 numbers and prints their sum
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Entre three numbers:");

        Console.WriteLine("number 1=");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("number2=");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("number3=");
        int number3 = int.Parse(Console.ReadLine());

        int sum = number1 + number2 + number3;
        Console.WriteLine("The sum of the three numbers is:" + sum);
    }
}