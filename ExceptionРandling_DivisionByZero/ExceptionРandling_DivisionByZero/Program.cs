class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter number one");
                double oneNum = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                double secNum = double.Parse(Console.ReadLine());

                if (secNum == 0)
                {
                    throw new Exception();
                }
                else
                {
                    double result = oneNum / secNum;
                    Console.WriteLine($"Result: {result}");
                    Console.ReadLine();
                }
            }
            catch 
            {
                Console.WriteLine("Failed! ");
                Console.ReadLine();
            }
        }
    }
}