using Classes;

public static class Program
{
    public static void Main()
    {
        //string name = "Ronaldo";
        //string country = "Portugal";
        //double rating = 100;

        //string name2 = "Hagi";
        //string country2 = "Romania";
        //double rating2 = 100;'
         
        FootballPlayer ronaldo1 = new FootballPlayer();
        ronaldo1.Name = "Ronaldo";
        ronaldo1.Country = "Portugal";
        ronaldo1.Rateing = 100;
        ronaldo1.Age = -87;

        Console.WriteLine(ronaldo1);
        Console.WriteLine($"{ronaldo1.Name} is from {ronaldo1.Country} with the score rating{ronaldo1.Rateing} and is {ronaldo1.Age} old");
            
        FootballPlayer hagi=new FootballPlayer("Hagi");
        Console.WriteLine($"{hagi.Name} is from {hagi.Country} with the score rating{hagi.Rateing} and is {hagi.Age} old");

    }
}