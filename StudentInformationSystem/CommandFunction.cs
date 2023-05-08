using System;
namespace SIS
{
	public class CommandFunction
	{
		public int choices;

		public void askLogout()
		{
			choices = Convert.ToInt32(Console.ReadLine());
            DisplayLayout dl = new DisplayLayout();

            switch (choices)
			{
				case 1:
					Console.WriteLine("Under Construction");
					break;

				case 2:
					Console.WriteLine("\n!!!System Log out!!!!");
					break;

				default:
					Console.WriteLine("\nERROR: Please enter a correct number");
					dl.userInput();
					askLogout();
					break;
			}
		}
	}
}

