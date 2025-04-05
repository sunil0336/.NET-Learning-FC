using System;

namespace MyOperations
{
    // Custom Exception Class
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; }

        public MyCustomException(int code, string message) : base(message)
        {
            ErrorCode = code;
        }

        public void DisplayError()
        {
            Console.WriteLine($"Error Code: {ErrorCode}, Error Message: {Message}");
        }
    }

    // MyOperations Class
    public class Operations
    {
        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Brooo Cannot divide by zero.");
            }
        }

        public static int AccessArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Index is out of range.");
            }
        }
    }
}
