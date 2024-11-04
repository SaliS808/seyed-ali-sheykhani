using System;

class Program
{
    static void Main()
    {
        Console.Write("یک عدد وارد کنید: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (IsPrime(number))
        {
            Console.WriteLine("عدد اول است.");
        }
        else
        {
            Console.WriteLine("عدد اول نیست.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}