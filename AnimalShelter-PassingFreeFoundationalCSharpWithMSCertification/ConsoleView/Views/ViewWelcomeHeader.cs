using ConsoleView.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleView.Views;

public class ViewWelcomeHeader() : View
{
    public new void Show() => Console.WriteLine("{0} {1} \n{2}",  
        GetString("WelcomeHeader"), GetString("MenuOptions"), GetString("ExitInput"));
}
