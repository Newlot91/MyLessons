using System;
using MyLib;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string URI = "https://metanit.com/sharp/tutorial/2.32.php";
            Console.WriteLine($"Your URI: {URI}");
            string hostName = MyLiblary.GetHostNameFromURI(URI);
            Console.WriteLine($"Hots: {hostName}");
            string protocol = MyLiblary.GetProtocolFromURI(URI);
            Console.WriteLine($"Protocol: {protocol}");
            Console.WriteLine();
            URI = "https://topseller.devstation.ru/fbo_vs_fbs";
            Console.WriteLine($"Your URI: {URI}");
            hostName = MyLiblary.GetHostNameFromURI(URI);
            Console.WriteLine($"Hots: {hostName}");
            protocol = MyLiblary.GetProtocolFromURI(URI);
            Console.WriteLine($"Protocol: {protocol}");
            Console.ReadKey();
        }
    }
}