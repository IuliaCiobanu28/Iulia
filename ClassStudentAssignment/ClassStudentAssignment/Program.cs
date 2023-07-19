public static class Program
{
    public static void Main()
    {
        int nrelevi = 3;
        string name;
        int age;
        decimal Mark;
        decimal sumMark=0;
        List<Student> students=new List<Student>();

        for(int i = 0; i < nrelevi; i++)
        {
            Console.WriteLine($"Student{i}:");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Mark = decimal.Parse(Console.ReadLine());
            students.Add(new Student(name, age, Mark));
        }

        for (int i = 0; i < nrelevi; i++)
        {
            Console.WriteLine("INFO:"+students[i].Info);
            sumMark = sumMark + students[i].Mark;
        }
        var averageMark=sumMark/nrelevi;
        Console.WriteLine("AVG MARK:"+averageMark);
       
    }
}

public class Student
{
    private string name;
    private int age;
    private const int MIN_AGE = 18;
    private const int MAX_AGE = 99;

    public int Age
    {
        get { return age; }
        set 
        {
            if (value < MIN_AGE)
                age = MIN_AGE;
            else if(value > MAX_AGE)
                age = MAX_AGE;
            else
                age = value;
        }
    }
    public decimal Mark { get;set; }
    public Student(string name, int age, decimal mark)
    {
        this.name = name;
        this.Age = age;
        this.Mark = mark;
    }
    public string Info { get { return name + " " + age; } }
}


