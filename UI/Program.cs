using System;
using System.Collections.Generic;
using MODEL;

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
        SISType type;

        //Validating if user is student,faculty,admin
        CommonCodes.userInput();
        CommonCodes.intChoices = Convert.ToInt32(Console.ReadLine());

        switch (CommonCodes.intChoices)
        {
            case 1: //student
                type = SISType.Student;
                getCredentials.userStudentCredentials();
                break;

            case 2: //faculty
                type = SISType.Faculty;
                break;
            case 3: //admin
                type = SISType.Admin;
                break;

            default:

                break;
        }

    }
}

