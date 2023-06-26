//Write a method that to remove the characters which have odd index values of a given string
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Your string is:");
        string str=Console.ReadLine();
        string Str = null;
        for(int i=0; i<str.Length; i++)
        {
            if (i % 2 == 0)
            {
                Str = Str + str[i];
            }
        }
        Console.WriteLine("The new string is:" +Str);
    }

}