namespace SingletonPattern;

internal class TableServers
{

    private List<string> servers = new List<string>();

    private int nextServer = 0;

    public TableServers()
    {

        servers.Add("Peter");
        servers.Add("Mary");
        servers.Add("Jeff");
        servers.Add("Emma");

    }

    public string GetNextServer()
    {

        string output = servers[nextServer];

        nextServer++;

        if(nextServer >= servers.Count)
        {

            nextServer = 0;

        }

        return output;

    }

}