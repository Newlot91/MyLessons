using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryApp
{
    interface IHistoryApp
    {
        public void GoToPage(string url,Stack<String> history);
        public void PageFromHistory(Stack<string> backHistory, Stack<string> forwardHistory);
        public void ShowHistoryOf50(Stack<string> backHistory);
    }
}
