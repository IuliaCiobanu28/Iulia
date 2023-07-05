//Write a method to reverse the order of the items in the array

using System.Runtime.ConstrainedExecution;

public static class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        
        ReversedArray(array);
        Console.WriteLine("Your reversed array is:");
        PrintArray(array);
    }
    public static void ReversedArray(int[] array)
    {
        int[] array2=new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            array2[i] = array[i];

        }
    }
    public static void PrintArray(int[] array2)
    {
        for(int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
       
    }
}