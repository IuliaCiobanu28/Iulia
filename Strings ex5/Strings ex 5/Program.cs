//Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long,
//the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input your string:");
        string str=Console.ReadLine();

        if(str.Length>50)
        {
            str[50] = "\n";
            str=String.Format(str)
        }
    }
}