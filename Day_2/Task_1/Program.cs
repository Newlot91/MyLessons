using System;

namespace Task_1
    /*Task 1. Create a simple loop. You should output each iterate to console like ‘Current iteration = “#”’. 
      The length of iteration can be imagined by yourself.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            for (int i = 0; i < 13; i++)
            {
                if (i <= 1)
                {
                    Console.WriteLine($"Number of printed line is {counter}");
                }
                else
                {
                    Console.WriteLine($"Number of printed lines are {counter}");
                }
                counter++;
            }
        }
    }
 }
