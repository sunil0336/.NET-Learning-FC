// *********      1. C# Language Basics      ******

using System;

class Program
{

    static bool IsPalindromeRecursive(int num, int rev, int temp)
    {
        if (temp == 0)
            return num == rev;

        return IsPalindromeRecursive(num, rev * 10 + temp % 10, temp / 10);
    }

    static bool IsPalindrome(int num)
    {
        int original = num, reverse = 0;
        while (num > 0)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }
        return original == reverse;
    }

    static void Main()
    {
        Console.WriteLine("1\n A");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            Console.WriteLine("String must have at least two characters.");
        }
        else
        {
            char first = input[0];
            char last = input[input.Length - 1];
            string shuffled = last + input.Substring(1, input.Length - 2) + first;

            Console.WriteLine("Shuffled String: " + shuffled);
        }
//********************
        Console.WriteLine("B");
        //2 
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("Sum of all digits: " + sum);

        Console.WriteLine("2 \n A Using Recursion");

//********************
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindromeRecursive(n, 0, n);

        Console.WriteLine(isPalindrome ? "The number is a Palindrome." : "The number is NOT a Palindrome.");


 //********************
        Console.WriteLine(" Without Using Recursion ");

        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPalindrome(num) ? "The number is a Palindrome." : "The number is NOT a Palindrome.");


    }
}
