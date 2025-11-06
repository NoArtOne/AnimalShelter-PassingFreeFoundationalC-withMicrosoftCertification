using ConsoleView.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView.Views
{
    internal class ViewUserEnteredInvalidInput : View
    {
        public new void Show() => Console.WriteLine("{0}",
        GetString("InvalidInput"));
    }
}
