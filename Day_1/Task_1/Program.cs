using System;

namespace Task_1
/*Task 1. Create a Console Application.
    Project name should match this pattern: Day1_Task# (where # is the task number, example Day1_Task1).
    Try to output to the console your data: Name, Surname, Age, City, Education.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alexander";
            string surname = "Yermalovich";
            string age = "30";
            string city = "Minsk";
            string education = "higher education";
            Console.WriteLine($"My name is {name} {surname}. I'm {age} yeas old. I from {city} and i have {education}.");
        }
    }
}
