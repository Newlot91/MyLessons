using System;

namespace Task_3
{
    class Program
    {/*Task 3. multiply
    Create an algorithm to multiply two int values but you must not use ‘*’ sign.
    Return the result and display it for the user.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int y = int.Parse(Console.ReadLine());
            int result = multiply(x, y);
            multiply(x,y);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
        static int multiply(int x, int y)
        {
            int result = 0;
            for (int i = 0 ; i<y; i++)
            {                
                result += x;
            }
            return result;
        }
    }
}
