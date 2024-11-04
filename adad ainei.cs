using System;

class Program
{
    static void Main()
    {
        Console.Write("یک عدد وارد کنید: ");
        string input = Console.ReadLine();
        
        if (IsPalindrome(input))
        {
            Console.WriteLine("عدد آیینه‌ای است.");
        }
        else
        {
            Console.WriteLine("عدد آیینه‌ای نیست.");
        }
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

