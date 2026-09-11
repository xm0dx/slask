namespace SimpeltGit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(DoSomething("Micheal!"));
    }

    static string DoSomething(string name)
    {
        return $"Hello, {name}!";
    }
}

