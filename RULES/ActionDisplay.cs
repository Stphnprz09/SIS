using System;
using DATA;
using MODEL;

namespace RULES
{
	public class ActionDisplay
	{
        public static int choices;
        public static char commandOption;

        //viewing main interface
        public static int actionMainDisplay()
        {
            choices = Convert.ToInt32(Console.ReadLine());
            switch (choices)
            {
                case 1: //student info
                    Display.viewStudentInfo();
                    actionReturn(commandOption);
                    //Display.mainDisplay();
                    break;

                case 2: //personal info
                    //Display.viewPersonalInfo();
                    Display.viewMenuPersonalInfo();
                    //actionReturn(commandOption);
                    break;

                case 3: //course description
                    Console.WriteLine("\nOn progress..");
                    actionReturn(commandOption);
                    break;

                case 4: //log out
                    Console.WriteLine("\nSystem log out");
                    break;

            }
            return choices;
        }

        //validating if student,faculty,admin
        public static void actionSISType()
        {
            SISType type;

            CommonCodes.userInput();
            choices = Convert.ToInt32(Console.ReadLine());

            switch (choices)
            {
                case 1: //student
                    type = SISType.Student;
                    getCredentials.userCredentials();
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

        //command to return
        public static void actionReturn(char commandOption)
        {
            Console.Write("\nDo you want to continue?[type any to continue/type N to end]\n");
            CommonCodes.userInput();
            commandOption = Convert.ToChar(Console.ReadLine());

            while(commandOption != 'N')
            {
                Display.mainDisplay();
                actionMainDisplay();
                break;
            }
            Console.WriteLine("\nSystem end");

        }

        //choices for student personal info
        public static void actionPersonalInfo()
        {
            choices = Convert.ToInt32(Console.ReadLine());
            switch (choices)
            {
                case 1: //viewing
                    Display.viewPersonalInfo();
                    actionReturn(commandOption);
                    break;

                case 2: //updating
                    UpdateClass.editPersonalInfo();
                    break;

                case 3:
                    break;
            }
        }
    }
}

