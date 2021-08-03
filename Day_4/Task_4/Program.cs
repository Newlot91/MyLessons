using System;

namespace Task_4
{
    class Program
    {
        /*Task 3. Sum
        Create an algorithm to sum two int values but you must not use ‘*’ sign.
        Return the result and display it for the user.

        Task 4**. Try to do Task 3 by using recursion.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int y = int.Parse(Console.ReadLine());
            int result = multiplyRecurs(x, y);
            multiplyRecurs(x, y);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
        static int multiplyRecurs(int x, int y)
        {
            if (y==0) 
            {
                return 0;
            }
            return x + multiplyRecurs(x, y - 1);
        }
    }
}
