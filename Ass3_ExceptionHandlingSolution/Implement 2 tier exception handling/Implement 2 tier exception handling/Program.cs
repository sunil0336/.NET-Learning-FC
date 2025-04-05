using System;
using MyOperations;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int den = int.Parse(Console.ReadLine());

            int result = Operations.Divide(num, den);
            Console.WriteLine("Result: " + result);
        }
        catch (MyCustomException ex)
        {
            ex.DisplayError();
        }

        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("Enter index to access: ");
            int index = int.Parse(Console.ReadLine());

            int value = Operations.AccessArrayElement(arr, index);
            Console.WriteLine("Value at index: " + value);
        }
        catch (MyCustomException ex)
        {
            ex.DisplayError();
        }
    }
}
