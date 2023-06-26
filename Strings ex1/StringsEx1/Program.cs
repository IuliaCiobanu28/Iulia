//Write a method that to remove the nth index character from a nonempty string.
public static class Program
{
    public static void Main()
    {
        Console.Write("Input your string:");
        string str=Console.ReadLine(); ;

        Console.Write("N'th index is:"); 
        int n=int.Parse(Console.ReadLine()) ;

        string Str=str.Remove(n-1,1) ;
        Console.WriteLine("The new string is:"+ Str) ;
    }
}
