using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً یک عدد وارد کنید:");

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"شما عدد {number} را وارد کردید.");
                break; // خروج از حلقه در صورت وارد کردن عدد
            }
            else
            {
                Console.WriteLine("ورودی نامعتبر است. لطفاً فقط عدد وارد کنید:");
            }
        }
    }
}