//Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.

public static class Program
{
    public static void Main()
    {
        Arrays();

    }
    public static void Arrays()
    {
        int[] Array = new int[5] { 1, 2, 3, 4, 5 };
        int index = int.Parse(Console.ReadLine());

        if (index <= Array.Length)
            Console.WriteLine("The element on the chosen position is:" + Array[index]);
        else
            Console.WriteLine("invalid index");
    }
}