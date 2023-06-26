// See https://aka.ms/new-console-template for more information
//3.Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

public static class Radius
{
    public static void Main()
    {

        Console.WriteLine("The radius of the circle is:");
        double r = int.Parse(Console.ReadLine());

        double perimetre = 2 * Math.PI * r;
        Console.WriteLine("The perimeter of the circle is: " + perimetre);

        double area=Math.PI * r * r;
        Console.WriteLine("The area of the circle is:"+area);
    }
}