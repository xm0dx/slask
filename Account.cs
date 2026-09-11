namespace SimpeltGit;

public class Account
{
    public int Balance { get; set; }

    public string AccountNummer { get; set; } = " ";

    public void Deposit(int amount)
    {
        Console.WriteLine("Nisse was here!");
    }
}
