namespace DataTypes;

public class Program
{
    static void Main()
    {
        // STRONGLY TYPED
        // Statically typed - The type of data a variable contains must be defined;
        // Type safe - We cannot assign different typed data to a variable;
        // Memory safe - Memory size of variables are known;

        // Example of underflow
        byte aggro = 0;
        Console.WriteLine("Ghandi's aggro is " + aggro);
        aggro -= 1;
        Console.WriteLine("Ghandi's aggro is " + aggro);

        checked    // Checks a block for Overflow Exceptions
        {
            byte aggro2 = 0;
            Console.WriteLine("Ghandi's aggro is " + aggro2);

            //aggro2 -= 1;
            //Console.WriteLine("Ghandi's aggro is " + aggro2);
        }

        #region numeric data types

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

        #endregion

        #region Type Conversion

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

        double x = 3.14159265359;
        // unsafe type conversion using the casting operator()
        float y = (float)x;

        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        int numCows = 300;
        uint numCowsU = (uint)numCows;
        byte numCowsB = (byte)numCows;

        Console.WriteLine("numCows = " + numCows);
        Console.WriteLine("numCowsU = " + numCowsU);
        Console.WriteLine("numCowsB = " + numCowsB);

        int studentLoan = -10000;
        uint studentLoanU = (uint)studentLoan;

        Console.WriteLine("studentLoan = " + studentLoan);
        Console.WriteLine("studentLoanU = " + studentLoanU);

        // Using the Convert class
        numCowsB = Convert.ToByte(numCows);     // The Convert class do background checks and will throw an Exception
        int myFive = Convert.ToInt32("Five");

        #endregion
    }
}