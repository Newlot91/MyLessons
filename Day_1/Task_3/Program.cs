using System;

namespace Task_3
/*Task 3*. Try to extend the program from Task 2 and add some additional messages from the program. 
 It can be asking your age, surname, place of birth, etc. */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, answer for next questions.");
            int countLine = 0;

            Console.WriteLine($"{++countLine}. Enter your name.");
            string name =
                Console.ReadLine();
            Console.WriteLine($"{++countLine}. Enter yuor surname.");
            string surname =
                Console.ReadLine();
            Console.WriteLine($"{++countLine}. Enter yuor age.");
            string age = Console.ReadLine();
            Console.WriteLine($"{++countLine}. Enter yuor city.");
            string city =
                Console.ReadLine();
            Console.WriteLine($"{++countLine}. Enter yuor education.");
            string education =
                Console.ReadLine();

            Console.WriteLine("Check your information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Education: {education}");
        }
    }
}
