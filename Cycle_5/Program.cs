using System;
class Program
{
    static void Main()
    {
        int sumOfPrimes = 0;
        for (int i = 2; i <= 50; i++)
        {
            if (IsPrime(i))
            {
                sumOfPrimes += i;
            }
        }
        Console.WriteLine($"Сумма простых чисел от 1 до 50: {sumOfPrimes}");
    }
    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}