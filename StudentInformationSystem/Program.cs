namespace SIS;
class Program
{
    static void Main(string[] args)
    {
        //this will be our main program, create your designated class to create function on your code
        DisplayLayout dl = new DisplayLayout();
        dl.mainDisplay();
        dl.userInput();

        CommandFunction cf = new CommandFunction();
        cf.askLogout();
    }
}

