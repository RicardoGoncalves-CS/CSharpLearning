namespace SingletonPattern;

// Thread safe Singleton Pattern implementation
sealed class TableServersSingleton
{

    private static TableServersSingleton _instance;

    private static readonly object _lock;

    private List<string> servers = new List<string>();

    private int nextServer = 0;

    private TableServersSingleton()
    {

        servers.Add("Peter");
        servers.Add("Mary");
        servers.Add("Jeff");
        servers.Add("Emma");

    }

    public static TableServersSingleton GetTableServers()
    {

        if(_instance == null)
        {

            lock (_lock)
            {

                if(_instance == null)
                {

                    _instance = new TableServersSingleton();

                }

            } 

        }

        return _instance;
    }

    public string GetNextServer()
    {
        string output = servers[nextServer];

        nextServer++;

        if (nextServer >= servers.Count)
        {

            nextServer = 0;

        }

        return output;

    }

}
