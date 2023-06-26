// See https://aka.ms/new-console-template for more information

//Write a program that reads five numbers from the console and prints the greatest of them.
public static class GreatestValue
{
    public static void Main()
    {
        Console.WriteLine("Entre five numbers:");

        Console.WriteLine("number1=");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("number2-=");
        decimal number2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("number3=");
        decimal number3 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("number 4=");
        decimal number4 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("number 5=");
        decimal number5 = decimal.Parse(Console.ReadLine());

        decimal[] biggestnumber = { number1, number2, number3, number4, number5 };
        decimal greatestnumber = biggestnumber.Max();

        Console.WriteLine("The greatest number is:" + greatestnumber);
    }
}
