using System;
using MyLib;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dh231n4f8f12h";
            Console.WriteLine(MyLiblary.GetNumberOfNumbersInString(s));
            string[] words = { "Hello", "my", "name", "is", "Patrik" };
            Console.WriteLine(MyLiblary.GetMaxWord(words));        
        }
    }
}
