using System;
using MyLibDay10;
/*Task 3*. Extend client app.
 * Extend your console app (Task 2). Create 5 users and add them to the array. 
 * Display all created users. Add a private method into the client app to remove a specific user from the array (for instance, remove a person who works in EPAM).
 * Don’t forget to remove default values to keep data clear.
*/
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.name = "Alexander";
            user1.surname = "Yermalovich";
            user1.age = 30;
            user1.companyName = CompanyName.unemployed;

            User user2 = new User();
            user2.name = "Andrei";
            user2.surname = "Yermalovich";
            user2.age = 25;
            user2.companyName = CompanyName.unemployed;

            User user3 = new User();
            user3.name = "Anastasiya";
            user3.surname = "Yermalovich";
            user3.age = 28;
            user3.companyName = CompanyName.Amazon;

            User user4 = new User();
            user4.name = "Anna";
            user4.surname = "Herasimenko";
            user4.age = 24;
            user4.companyName = CompanyName.EPAM;

            User user5 = new User();
            user5.name = "Kirill";
            user5.surname = "Korzun";
            user5.age = 25;
            user5.companyName = CompanyName.EPAM;

            //Display all created users
            User[] users = { user1, user2, user3, user4, user5 };
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].GetUserName());
                Console.WriteLine(users[i].GetAge());
                Console.WriteLine(users[i].GetWorkCompany() + "\n");
            }

            users = RemoveEpam(users);//filtering
            Console.WriteLine("***************************") ;
            Console.WriteLine("Filtered none EPAM");  
            
            //Display all none epam users
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].GetUserName());
                Console.WriteLine(users[i].GetAge());
                Console.WriteLine(users[i].GetWorkCompany() + "\n");
            }

            static User[] RemoveEpam(User[] users)
            {
                User[] filteredUsers = new User[1];
                int countForFilter = 0;
                for (int i = 0; i < users.Length; i++)
                {

                    if (users[i].companyName!=CompanyName.EPAM )
                    {
                        
                        filteredUsers[countForFilter] = users[i];
                        Array.Resize(ref filteredUsers, filteredUsers.Length+1);
                        countForFilter++;
                    }
                }
                Array.Resize(ref filteredUsers, filteredUsers.Length - 1);
                return filteredUsers;
            }
        }
    }
}
