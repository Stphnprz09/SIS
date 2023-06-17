using System;
using System.Collections.Generic;

using RULES;

namespace UI;
class Program
{
    static void Main(string[] args)
    {
        List<string> SISQuestion = new List<string> { "[1] Student", "[2] Faculty", "[3] Admin\n" };
        Console.WriteLine("!!!Welcome to PUPHUB System!!!\n>> Please enter a number you want to choose\n");
        foreach(var view in SISQuestion)
        {
            Console.WriteLine(view);
        }
        ActionDisplay.actionSISType();
    }
}

