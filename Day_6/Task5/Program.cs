using System;

//Task 5. Implement search for max element in array (use linear algorithm).
//Task 6. Implement search for min elements in the array (use linear algorithm).
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 95, 35, 1, 21, 15, 13, 88, 44, 17, 2 };
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int minNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum) minNum = numbers[i];
            }
            Console.WriteLine($"Min.number is {minNum}");
            int maxNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNum) maxNum = numbers[i];
            }
            Console.WriteLine($"Max.number is {maxNum}");
            Console.ReadLine();
        }
    }
}
