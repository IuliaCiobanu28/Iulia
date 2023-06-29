//Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.

using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main()
    {
        CreateAndPrintArray();
    }
    public static void CreateAndPrintArray()
    {
        //declare and assign an emty array
        int[] numbers = new int[5] {1,2,3,4,5};
        //give elements to the array

        for(int index=0; index<numbers.Length; index++)
        {
            Console.WriteLine(numbers[index]);
        }
    }
}
