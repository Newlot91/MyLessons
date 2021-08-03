using System;

namespace Task_1
{
    /*Task 1: Create two methods.

The first method iterates input parameter X. The method takes integer N, where N determines the number of loop iterations. 
    The method must return X value after incrementing. Use X as a ‘ref’ parameter for the method.
The second method iterates input parameter X. The method takes integer N, where N determines the number of loop iterations. 
    The method must return X value after incrementing. Use X as an ‘out’ parameter for the method.
Output results to the Console.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number that you wnat to eterate.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of iteration.");
            int n = int.Parse(Console.ReadLine());
            int y;
            iteraX(ref x, n);
            iteraOut(x, n, out y);
            Console.WriteLine(y);
            Console.ReadLine();
        }
        static int iteraX(ref int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                x++;
            }
            Console.WriteLine($"Your number after iteration: {x}");
            return x;
        }
        static void iteraOut(int z, int n, out int x)
        {            
            x = z;
            for (int i = 0; i < n; i++)
            {
                x++;
            }
            Console.WriteLine($"Your number after iteration: {x}");
        }
    }
}
