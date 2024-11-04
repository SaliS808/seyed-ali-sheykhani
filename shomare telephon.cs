using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = @"
        Hello, my phone number is 0123456789, my address is rue Voltaire 145.  
        the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question 
        the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question 
        Our customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899";

        List<string> validPhoneNumbers = ExtractValidPhoneNumbers(input);

        Console.WriteLine("Valid phone numbers:");
        foreach (string number in validPhoneNumbers)
        {
            Console.WriteLine(number);
        }
    }

    static List<string> ExtractValidPhoneNumbers(string input)
    {
        var validNumbers = new List<string>();
        var regex = new Regex(@"\b(0\d{9})\b");

        foreach (Match match in regex.Matches(input))
        {
            string number = match.Value;

            if (IsValidPhoneNumber(number))
            {
                validNumbers.Add(number);
            }
        }

        return validNumbers;
    }

    static bool IsValidPhoneNumber(string number)
    {
        // Check if the number has at least two different digits
        HashSet<char> uniqueDigits = new HashSet<char>(number);
        return uniqueDigits.Count >= 2;
    }
}