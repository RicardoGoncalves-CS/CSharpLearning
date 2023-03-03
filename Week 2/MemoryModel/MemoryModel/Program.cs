namespace MemoryModel;

public class Program
{
    static void Main()
    {
        int alin = 100;
        string ruya = "Ruya";
        
        double alex = 3.3;
        int[] samson = { 11, 65, 21 };
        string[] mubashir = { "ricardo", "connor", "ali" };

        {
            //value types are COPIED over
            var rakesh = alin;
            rakesh++;

            //reference types COPY the ADDRESS, so the HEAP information is unchanged
            //(points to the same location)
            var byron = samson;
            byron[2] = 44;
            Console.WriteLine(samson[2]);

            string[] valentin = { "owls", "dogs" };
            // ricardo, connor and ali get unreferenced
            mubashir = valentin;

            // the string get's added (immutable), and the address values get updated
            mubashir[0] = "a bird";
            Console.WriteLine(valentin[0]);

            //another reference assignment
            string luke = ruya;
            //we create a new CAPITALISED string, and luke's address pointer is updated
            luke = luke.ToUpper();
        }
        //all variables defined in the prior scope are popped off the stack

        int ali = DemoMethod(samson, alin);
        //jack and max are out of scope, they get popped off the stack

        PassByReferenceDemo(alin, ali);
    }

    static int DemoMethod(int[] jack, int max)
    {
        max *= 2;
        jack[1] = 404;

        return jack[0];
    } 

    static void PassByReferenceDemo(in int ricardo, out int luke)
    {
        luke = ricardo + 1;
    }
}