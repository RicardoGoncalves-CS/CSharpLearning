namespace CSharpExploration.App.Singleton;

internal class BarMan
{
    private BarMan() { }

    private static readonly object _locked = new Object();

    private static BarMan? _instance;

    public static BarMan Instance
    {
        get
        {
            lock (_locked)
            {
                if(_instance == null)
                {
                    _instance = new BarMan();
                }
                return _instance;
            }
        }
    }
}
