using JurassicPark.Management;

namespace JurassicPark;

internal static class Controller
{
    public static void Start()
    {
        View.Greetings();

        string option = "Main menu";

        while (option != "Quit")
        {
            if(option == "Main menu")
            {
                option = View.MainMenu();
            }
            else if(option == "Register new employee")
            {
                option = View.RegisterEmployeeMenu();
                if (option == "Register new scientist")
                {
                    Register.NewScientist();
                }
            }
            else if(option == "Register new visitor")
            {
                option = View.RegisterVisitorMenu();
            }
            else
            {
                option = "Main menu";
            } 
        }

        View.Farewell();
    }
}