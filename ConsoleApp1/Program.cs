// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        string dogName = "Bingo";
        int dogAge = 5;
        char exclamation = '!';
        bool isLab = false;
        double milesWalked = 2.75;
        decimal height = 2.5m;

        Console.WriteLine("Enter in your dog's name:");
        dogName = Console.ReadLine();

        Console.WriteLine(dogName);
        Console.WriteLine(dogAge);

    }

}
