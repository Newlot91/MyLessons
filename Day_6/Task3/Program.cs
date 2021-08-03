using System;

namespace Task4
//Task 4. Implement a linear search algorithm.
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {95,35,1,21,15,13,88,44,17,2};
            foreach (int num in numbers)
                Console.Write(num+" ");
            Console.WriteLine();
            int searechNum = int.Parse(Console.ReadLine());
            for (int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] == searechNum)
                {
                    Console.WriteLine($"Your searcing number element is {i}");
                }
                else
                    Console.WriteLine($"Your searcing number element is not found.");
            }
        }//4684
    }
}
