using System;

namespace Task_2
/*Task 2. 
 * Create a loop.Amount of iteration = 20. The program works until 10 iterations.
* After 10 iterations you must break from the loop and notify the console about it like ‘The loop is cancelled’. 
* Each iteration must be notified in Console.
* 
* 
* Task 3*.
* Try to extend the program from Task 2. Add one int variable with value = 1. 
* Each iteration you must increment your variable. 
* When the variable is 10 you must notify the user about it and there are two options: continue to iterate or break from the cycle. Write each step in the console.
* 
* 
Task 4**.
Do Task 3* with 3 types of loop (while, do..while, for)

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int onStock = 1;
            for (int order = 0; order < 20; order++)
            {
                Console.WriteLine($"NUmber of iteration {order}");

                if (onStock==10)
                {
                    Console.WriteLine($"On stock variable is {onStock}. Continue(1) or break(2)?");
                    string choise = Console.ReadLine();
                    if (choise == "1")
                    {
                        onStock++;
                        continue;
                    }
                    if (choise == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect command.");
                        break;
                    }
                }
                onStock++;

            }
            Console.ReadLine();
        }
    }
}


/* task 2
 * int onStock = 10;
            for (int order = 1; order < 21; order++)
            { if (order == onStock)
                    break; 
                Console.WriteLine($"Your order: {order}pcs.");
                   
            }
            Console.WriteLine("The loop is cancelled");
        }
*/

/* task 3
 { int onStock = 10;
            for (int order = 1; order < 20; order++)
            { if (order == onStock)
                    continue;
                Console.WriteLine($"Your order: {order}pcs.");
                   
            }
        }
*/