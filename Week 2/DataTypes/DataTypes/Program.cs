namespace DataTypes;

public class Program
{
    static void Main()
    {
        // STRONGLY TYPED
        // Statically typed - The type of data a variable contains must be defined;
        // Type safe - We cannot assign different typed data to a variable;
        // Memory safe - Memory size of variables are known;

        int a = 25;
        uint b = 25u;
        double c = 25.5d;
        decimal d = 25.5m;
        ulong hugeNumber = 15_000_000_000_000_000ul;

        float sum = 0;
        for(int i = 0; i < 1_000_000; i++)
        {
            sum += 2 / 5f;
        }

        Console.WriteLine("2/5 added 1 million times: " + sum);
        Console.WriteLine("2/5 multiplied 1 million times in one calculation: " + 2/5f * 1_000_000);

        if (sum == 400_000) Console.WriteLine("Calculation success!");
        else Console.WriteLine("Calculation failure!");

        #region Conversion

        int kangaroosInSydney = 500;
        long kangaroosInAustralia;

        kangaroosInAustralia = kangaroosInSydney;       // safe conversion
        // kangaroosInSydney = kangaroosInAustralia;    // unsafe conversion
        kangaroosInAustralia = b;                       // safe conversion
        // kangaroosInAustralia = hugeNumber;           // unsafe conversion

        float pi = 3.14f;
        double cake = pi;                               // safe conversion
        // pi = cake;                                   // unsafe conversion
        // cake = d;                                    // unsafe conversion
        // pi = d;                                      // unsafe conversion
        // d = pi;                                      // unsafe conversion
        // d = cake;                                    // unsafe conversion

        cake = kangaroosInAustralia;                    // safe conversion
        // kangaroosInAustralia = cake;                 // unsafe conversion

        #endregion
    }
}