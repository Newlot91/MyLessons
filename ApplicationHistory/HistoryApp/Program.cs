using System;
using System.Collections.Generic;
using System.IO;

namespace HistoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <String> backHistory=new Stack<string> (50);
            Stack<String> forwardHistory = new Stack<string>(50);
            var appFeatures = new AppFeature();
            String path = @"D:\MyLessons\ApplicationHistory\";
            FileSystem.LoadData(path, ref  backHistory);
            bool isWorking = true;
            while (isWorking)
            {
            Console.WriteLine("Browser:)\n");
            Console.WriteLine("Select operation:");
            Console.WriteLine("1.Go to page");
            Console.WriteLine("2.Go Back");
            Console.WriteLine("3.Go Forward");
            Console.WriteLine("4.Show history");
            Console.WriteLine("5.Close browser");

            int selection = 0;
            int.TryParse(Console.ReadLine(),out selection);
                switch (selection)
                {
                    case 1://go to page
                        {
                            Console.Clear();
                            Console.WriteLine("Enter link:");
                            appFeatures.GoToPage(Console.ReadLine(), backHistory);
                            FileSystem.SaveData(path,backHistory);
                            break;
                        }
                    case 2://go back
                        {
                            appFeatures.PageFromHistory(backHistory, forwardHistory);
                            FileSystem.SaveData(path, backHistory);
                            break;
                        }
                    case 3://go forward
                        {
                            if (forwardHistory.Count > 0)
                            {
                                appFeatures.PageFromHistory(forwardHistory, backHistory);
                            }
                            else
                            {
                                Console.WriteLine("No forward history\n\n\n\n\n\n\n\n\n\n");
                            }
                            break;
                        }
                    case 4://Show history
                        {
                            appFeatures.ShowHistoryOf50(backHistory);
                            break;
                        }
                    case 5: // stop app
                        {
                            isWorking = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command");
                        }
                        break;
                }
            }
        }
    }
}
