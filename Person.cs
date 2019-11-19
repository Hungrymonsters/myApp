using static System.Console;
using System.Linq;

public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string MiddleName { get; } = "";

    public Person(string first, string middle, string last)
    {
        FirstName = first;
        MiddleName = middle;
        LastName = last;
    }

    public override string ToString() => $"{FirstName} {LastName}";
    public string AllCaps() => ToString().ToUpper();
}

public class Program
{
    public static void Main()
    {
        var p = new Person("Bill", "Jonathan", "Wagner");
        WriteLine($"The name, in all caps: {p.AllCaps()}");
        WriteLine($"The name is: {p}");

        var phrase = "the quick brown fox jumps over the lazy dog";
        var wordLength = from word in phrase.Split(' ') select word.Length;
        var average = wordLength.Average();
        WriteLine(average);
    }
}