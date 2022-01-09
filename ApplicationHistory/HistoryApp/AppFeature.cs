using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryApp
{
    public  class AppFeature : IHistoryApp
    {
        public  void GoToPage(string url, Stack<string> history)
        {
            Console.Clear();
            history.Push(url);
            Console.WriteLine("сейчас вы на странице:");
            Console.WriteLine($"{url}\n\n\n\n\n\n\n\n\n\n");
        }

        public  void PageFromHistory(Stack<string> backHistory, Stack<string> forwardHistory)//todo изменить момент перемещения ссылки по стекам
        {
            Console.Clear();
            Console.WriteLine("сейчас вы на странице:");
            Console.WriteLine($"{backHistory.Peek()}\n\n\n\n\n\n\n\n\n\n");
            forwardHistory.Push(backHistory.Pop());
        }

        public  void ShowHistoryOf50(Stack<string> backHistory)
        {
            Console.Clear();
            int count = 1;
            Console.WriteLine("Your browser history:");
            foreach (var link in backHistory)
            {
                Console.WriteLine($"{count}.{link}");
                count++;
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
        }
    }
}
