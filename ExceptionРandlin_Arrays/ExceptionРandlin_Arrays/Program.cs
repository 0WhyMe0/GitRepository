class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter length array! ");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] array = new int[lengthArray];

            Console.WriteLine("Enter array value! ");

            int average = 0;

            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                average += array[i];
            }

            average = average / 2;

            Console.WriteLine($"Arithmetic average: {average}");
            Console.ReadLine();
        }
        catch 
        {
            Console.WriteLine("Failed! ");
            Console.WriteLine("Incorrect data entered! ");
        }
    }
}