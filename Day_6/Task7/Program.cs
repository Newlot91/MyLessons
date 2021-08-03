using System;

/*Task 7.Implement array sorting by bubble sort algorithm.
*Do array validation on each algorithm (check for null, for array length). 
*If the input array did not pass validation – write a message to the console and I must not do an algorithm.
*/
namespace Task7
{
    class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements of the array that you want to create.");
                int arrayLenght = int.Parse(Console.ReadLine());
                int[] numbers = new int[arrayLenght];
                enterData(numbers);
                if (arrayLenght == 0)
                {
                    Console.WriteLine("I must not do an algorithm.");//messege Null array lenght.
                    break;
                }
                else
                {
                    sortArray(numbers);
                    changeINnumbers(numbers);
                }
            }
        }


        static void enterData(int[] numbers) //data entery
        {
            Console.WriteLine($"Enter {numbers.Length} random numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}# is ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        static void sortArray(int[] numbers) // Sorting array, by bubble sort
        {

            int transfer;
            for (int n1 = 0; n1 < numbers.Length - 1; n1++)
            {
                for (int n2 = n1 + 1; n2 < numbers.Length; n2++)
                {
                    if (numbers[n1] > numbers[n2])
                    {
                        transfer = numbers[n2];
                        numbers[n2] = numbers[n1];
                        numbers[n1] = transfer;
                    }
                }
            }
            Console.WriteLine("Your array numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }


        static void changeINnumbers(int[] numbers) //Changing numbers in array
        {
            bool IsContinued = true;
            do
            {
                Console.WriteLine("Press (1) if you want change value in array, press (2) if you want reset program.");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Enter your index to change.");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter you value to change");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine("Your array numbers: ");
                        numbers[index] = value;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        IsContinued = false;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
            while (IsContinued);
        }
    }
}
   