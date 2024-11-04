using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} در سری فیبوناچی وجود دارد.");
        }
        else
        {
            Console.WriteLine($"{n} در سری فیبوناچی وجود ندارد.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;

        if (n == a || n == b) return true;

        while (b < n)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == n;
    }
}