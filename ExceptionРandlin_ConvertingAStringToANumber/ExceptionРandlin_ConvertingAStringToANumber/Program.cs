class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter number! ");
            string stringNum = Console.ReadLine();

            double doubleNum = double.Parse(stringNum);
            Console.WriteLine("The conversion is successful!");
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Failed! You enter not number! ");
            Console.ReadLine();
        }
    }
}