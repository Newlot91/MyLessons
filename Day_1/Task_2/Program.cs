using System;

namespace Task_2
/*Task 2. Create a Console Application. 
 * When the program is started a message should appear like “What is your name?”
 * (or something like that, you can imagine) and the user should have the ability to enter your name and then press enter.
 * The program should show a message like “Your name is ###” (where ### is the value from the previous step).
 */


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}.");
        }
    }
}
