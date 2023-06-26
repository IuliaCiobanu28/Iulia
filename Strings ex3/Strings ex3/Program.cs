

using System.Text;

public static class Program
{
    public static void Main()
    {
        //Write a method that takes input from the user and displays that input back in upper and lower cases.
        Console.Write("Input your string:");
        string str = Console.ReadLine();

        Console.WriteLine("Your upper cases string is: " + str.ToUpper());
        Console.WriteLine("Your lower cases string is: " + str.ToLower());

        //Write a method that reverses a string if it's length is a multiple of 4
        Console.WriteLine("Your string is:");
        string str1=Console.ReadLine();
        if(str1.Length%4==0)
        {
           string ReversedStr=ReverseString(str1);
            Console.WriteLine("Your reversed string is:" + ReversedStr);
        }
        else
        {
            Console.WriteLine(str1);
        }
    }

    public static string ReverseString(string str)
    {
        StringBuilder Str = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
            Str.Append(str[i]);
        return Str.ToString();

    }
}
     