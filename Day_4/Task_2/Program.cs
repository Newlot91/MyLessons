using System;

namespace Task_2
{
    enum Operation
    {
        iteration = 1,
        decrement
    }
    class Program
    {
        /*Task 2: Extend the Task 1 and add a separate enum. 
         * Enum structure should determine only which operation should be done in methods from Task 1: iteration or decrement. 
         * Add validation for input parameter (enum) in a separate method.*/
        
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want (1)eterate or (2)decrement your number.");
            Operation op = 0;                   
            Console.WriteLine("Enter your number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many of operation that you want to do with your number.");
            int n = int.Parse(Console.ReadLine());           
            ChoiseOp( x, n, op);
            Console.ReadLine();
        }


        static void ChoiseOp ( int x, int n, Operation op)
        {

            switch (op)
            {
                case Operation.iteration:
                    iteraX( x ,n);
                    break;
                case Operation.decrement:
                    decremX( x, n);
                    break;
            }
        }


        static int iteraX( int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                x++;
            }
            Console.WriteLine($"Your number after iteration: {x}");
            return x;
        }


        static int decremX( int x, int n)        
        {
            for (int i = 0; i<n; i++)
            {
                x--;
            }
    Console.WriteLine($"Your number after iteration: {x}");
            return x;
        }
    }
}
