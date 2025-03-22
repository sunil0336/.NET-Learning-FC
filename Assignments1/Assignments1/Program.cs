using System;

class Program
{
    static void Main()
    {
        // a1q2
        Console.WriteLine("For Loop ");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("iteration  " + i);
        }

        Console.WriteLine("\nWhile Loop");
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine("Count is " + count);
            count++;
        }

        Console.WriteLine("\nDo-While Loop");
        int num = 0;
        do
        {
            Console.WriteLine("Number is " + num);
            num++;
        } while (num < 3);



        // a1 qus 1 

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        Console.Write("Enter a day number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number.");
                break;
        }
    }
}
