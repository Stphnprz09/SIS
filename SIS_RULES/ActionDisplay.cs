using System;
using SIS_DATA;

namespace SIS_RULES
{
	public class ActionDisplay
	{
        public static int choices;
        public static char commandOption;


        public static int actionMainDisplay()
        {
            choices = Convert.ToInt32(Console.ReadLine());
            //DisplayLayout dl = new DisplayLayout();

            switch (choices)
            {
                case 1:
                    Student.profile1();
                    Display.profileDisplay();
                    actionProfileDisplay();
                    break;

                case 2:
                    Console.WriteLine("\n!!!System Log out!!!!");
                    break;

                default:
                    Console.WriteLine("\nERROR: Please enter a correct number");
                    CommonCodes.userInput();
                    actionMainDisplay();
                    break;
            }
            return choices;
        }

        public static void actionProfileDisplay()
        {
            //Console.Write("")
            choices = Convert.ToInt32(Console.ReadLine());

            switch (choices)
            {
                case 1: //personal information
                    //Console.WriteLine("Under Construction");
                    InMemoryPersonalInfo.PersonalInfo1();
                    break;

                case 2: //course description
                    //Console.WriteLine("Under Construction");
                    CourseDescription.showCouseDescription();
                    break;
                case 3:
                    //Console.WriteLine("Under Construction");
                    Display.mainDisplay();
                    actionMainDisplay();
                    break;

                default:
                    Console.WriteLine("\nERROR: Please enter a correct number");
                    CommonCodes.userInput();
                    //actionMainDisplay();
                    break;
            }

        }
    }
}

