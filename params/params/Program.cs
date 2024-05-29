void Sum(int initialValue, params int[] numbers)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] a = { 1, 2, 3, 4, 5 };
Sum(10, a);