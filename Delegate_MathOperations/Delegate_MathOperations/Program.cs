using Delegate_MathOperations;
using System.Security.Cryptography.X509Certificates;

class Program
{ 
    static void Main(string[] args)
    {
        MathOp mathOp = new MathOp();

        mathOp.mathOperation = Result;

        mathOp.Added(10, 8);
        mathOp.UnAdded(10, 8);
        mathOp.Division(10, 8);
        mathOp.Multiplication(10, 8);
    }

    public static void Result(int result)
    {
        Console.WriteLine($"Result = {result}");
    }
}