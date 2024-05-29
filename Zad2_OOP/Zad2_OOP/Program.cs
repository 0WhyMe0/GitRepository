using Zad2_OOP;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        string person = user.Name("Dimaa");

        Console.WriteLine(person);
    }
}