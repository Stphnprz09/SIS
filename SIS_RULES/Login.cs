using System;
namespace SIS_RULES
{
    public class Login
    {
        public static void userLogin()
        {
            int attemptCount = 0;

            while (attemptCount < 3)
            {
                Console.WriteLine("!!!Welcome to PUPHUB Binan System!!! \n");
                Console.Write("<< Enter your school mail: ");
                string schoolmail = Console.ReadLine();

                Console.Write("<< Enter your password: ");
                string password = Console.ReadLine();

                // Check if the credentials are valid
                if (CheckCredentials(schoolmail, password))
                {
                    Console.WriteLine("\nLogin successful!\n");
                    CommonCodes.readKey();
                    Display.mainDisplay();
                    return;
                }
                else
                {
                    Console.WriteLine("ERROR: Incorrect credentials please try again.");
                    attemptCount++;
                }
            }

            // Maximum number of attempts reached
            Console.WriteLine("Maximum number of attempts reached. Login failed.");
        }

        static bool CheckCredentials(string schoolmail, string password)
        {
            return schoolmail == "2021-00066-BN-0" && password == "admin123";
        }
    }
}

