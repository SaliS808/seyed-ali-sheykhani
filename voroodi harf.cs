using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً یک کاراکتر وارد کنید:");

        while (true)
        {
            string input = Console.ReadLine();
            
            // بررسی طول ورودی
            if (input.Length == 1)
            {
                char character = input[0];
                Console.WriteLine($"شما کاراکتر '{character}' را وارد کردید.");
                break; // خروج از حلقه در صورت وارد کردن کاراکتر
            }
            else
            {
                Console.WriteLine("ورودی نامعتبر است. لطفاً فقط یک کاراکتر وارد کنید:");
            }
        }
    }
}