namespace SingletonPattern;

internal class Program
{
    // The two objects below create two different instances of TableServers
    static TableServers hostOneList = new TableServers();
    static TableServers hostTwoList = new TableServers();

    // The two objects below access the same instance of TableServersSingleton
    static TableServersSingleton hostThreeList = TableServersSingleton.GetTableServers();
    static TableServersSingleton hostFourList = TableServersSingleton.GetTableServers();

    static void Main(string[] args)
    {

        Console.WriteLine("Normal class objects:");

        for (int i = 0; i < 5; i++)
        {

            HostOneGetNextServer();
            HostTwoGetNextServer();

        }

        Console.WriteLine("------------------------------");

        Console.WriteLine("Singleton class objects:");

        for (int i = 0; i < 5; i++)
        {

            HostThreeGetNextServer();
            HostFourGetNextServer();

        }

    }

    
    private static void HostOneGetNextServer()
    {

        Console.WriteLine($"Next server is {hostOneList.GetNextServer()}");

    }


    private static void HostTwoGetNextServer()
    {

        Console.WriteLine($"Next server is {hostTwoList.GetNextServer()}");

    }

    private static void HostThreeGetNextServer()
    {

        Console.WriteLine($"Next server is {hostThreeList.GetNextServer()}");

    }

    private static void HostFourGetNextServer()
    {

        Console.WriteLine($"Next server is {hostFourList.GetNextServer()}");

    }
}