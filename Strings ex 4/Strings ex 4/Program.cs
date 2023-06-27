//Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters

using System.Runtime.CompilerServices;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input your string:");
        string str = Console.ReadLine();
        int n = 0;
        for (int i = 0; i < 4; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                n = n + 1;
            }
        }
        if (n >= 2)
        {
            str = str.ToUpper();
        }
        Console.WriteLine("Your String is:" + str);


        // Write a method that to remove a newline.

        String str1 = @"This is your string.
And this.
Same with this.";

        Console.WriteLine(str1);

        string Str = str1.Replace("\n"," ").Replace("\r"," ");
        Console.WriteLine(Str);
    }
}
