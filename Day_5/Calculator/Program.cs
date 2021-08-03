using System;

namespace Calculator
/*Task.  The program is a calculator.
+Before using the calculator, you must log into the application. Create a user (username and password must be kept in the code).
+Add a validate method to check username and password. You have only 3 attempts to log into the system. If the user is not found - the program must notify about it and close itself.

+Calculator operations: Sum, Minus, Divide, Multiply
+The Calculation method must take a 2 string value, not int/double/float, etc. (Try to parse the string to the correct type).
+All operations must be saved!!! (for example, I want to have a list of operations. The output is ‘5 + 6 = 11’, etc. 
+I recommend you to read about ‘string’ methods to do string concatenation, String.Concat/String.Join). Use an array to save history. 

+Check every time the array size before adding the result of operation. If you need to increase array size use Array.Resize method (check the link: https://docs.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-5.0) 
The GetMyOperations method can ask the user to clear the console if it’s necessary. As you wish.

The example of program menu:
Sum
Minus
Divide
Multiply
Get my operations
Exit

*** Extra. Add additional points into the Menu to have some actions to work with an array like Clear Array, Add Size. 
*The last action should return to the Menu. (the second menu will be like Clear, Add Size, Return to the Main Menu).
 */
{
    class Account //Create a user (username and password must be kept in the code).
    {
        public string AccountName;
        public string AccountPassword;
        public void GetInfo()
        {
            Console.WriteLine($"Your account: {AccountName}  Password: {AccountPassword}");
        }
    }
    enum Operation
    {
        Sum = 1,
        Minus,
        Divide,
        Multiply,
        myOpetarion,
        Exit
    }
    enum OperationSub
    {
        Clear = 1,
        Add_Size,
        Return_to_the_Main_Menu
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (CreatAcc() == false)
            {
                Console.WriteLine("Press any key to close the program");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine($"\nWelcom, User.");
            string[] MyOperations = new string[1];
            for (int i=0;;i++)
            {
                string temp = "Dont work";
                Console.Write("Enter first number: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double y = double.Parse(Console.ReadLine());            
                temp = Calc(x, y, MyOperations);
                MyOperations[i] = temp;
                Array.Resize(ref MyOperations, MyOperations.Length + 1);
            }
            Console.ReadLine();
        }
        public static bool CreatAcc()
        {
            Account user = new Account();
            Console.WriteLine("\tRegistration.\nEnter your account name.");
            user.AccountName = Console.ReadLine();
            Console.WriteLine("Enter your account password.");
            user.AccountPassword = Console.ReadLine();
            Console.WriteLine("Accout registration is successful.");
            int attempts = 3;
            for (int i = 0; i <= attempts; i++)
            {
                Console.WriteLine("\t\n Login.");
                Console.Write("Enter your Account: ");
                Account TryUser = new Account();
                TryUser.AccountName = Console.ReadLine();
                Console.Write("Enter your Password: ");
                TryUser.AccountPassword = Console.ReadLine();
                if (user.AccountName == TryUser.AccountName && (user.AccountPassword == TryUser.AccountPassword))
                {                    
                    Console.WriteLine("Login successful");
                    return true;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Wrong account or password. {attempts} attempts.");
                }
            }
            Console.WriteLine("Login unsuccessful");
            return false;
        }
        static string Calc(double x, double y,string [] MyOperations)//The Calculation method must take a 2 string value, not int/double/float, etc.
        {
            double result = 0.0;
            string temp = "";
            int counter = 1;
            Console.WriteLine("Choose operation that you want to do.\n");
            foreach (var value in Enum.GetValues(typeof(Operation))) //Show menu.
            {
                Console.WriteLine($"{counter}. {(Operation)value}");
                counter++;
            }
            switch (char.Parse(Console.ReadLine())) //Определение операции
            {
                case '1':
                    result = x + y;
                    temp = $"{x}+{y}={result}";
                    Console.WriteLine($"Result of your operation: {result}\n");
                    break;
                case '2':
                    result = x - y;
                    temp = $"{x}-{y}={result}";
                    Console.WriteLine($"Result of your operation: {result}\n");
                    break;
                case '3':
                    result = x / y;
                    temp = $"{x}/{y}={result}";
                    Console.WriteLine($"Result of your operation: {result}\n");
                    break;
                case '4':
                    result = x * y;
                    temp = $"{x}*{y}={result}";
                    Console.WriteLine($"Result of your operation: {result}\n");
                    break;
                case '5':
                    foreach (string Operation in MyOperations)
                        Console.WriteLine(Operation);
                    GetMyOperations(x,y,MyOperations);
                    break;
                case '6':
                    Environment.Exit(0);
                    break;
            }
            return temp;
        }
        static void GetMyOperations(double x, double y,string[] MyOperations)
        {
            int counter = 1;
            Console.WriteLine("Choose operation that you want to do.\n");
            foreach (var value in Enum.GetValues(typeof(OperationSub)))
            {
                Console.WriteLine($"{counter}. {(OperationSub)value}");
                counter++;
            }
                int lenght = 0;
                switch (char.Parse(Console.ReadLine()))
                {
                    case '1':
                        lenght = 0;
                        MyOperations[1] = default;
                        Array.Resize(ref MyOperations, lenght);
                        return;
                    case '2':
                        Console.Write("Select number of elements do you want to do in your array: ");
                        lenght = int.Parse(Console.ReadLine());
                        Array.Resize(ref MyOperations, lenght);
                        return;
                    case '3':
                        Calc(x, y, MyOperations);
                        return;
                }
            }
        }
    }

