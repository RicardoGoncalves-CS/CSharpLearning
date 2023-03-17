namespace JurassicPark;

internal static class Controller
{
    public static void Start()
    {
        string option = View.MainMenu();

        if (option.ToLower() != "quit")
        {
            if (option.ToLower() == "register")
            {
                View.RegisteryMenu();
            }
        }
    }
}
