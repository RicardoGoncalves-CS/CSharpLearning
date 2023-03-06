using static System.Net.Mime.MediaTypeNames;

namespace ExceptionsAndDataTypes;

public class Program
{
    static void Main()
    {
        // exception is a runtime error where the program (crashes) throws an exception object when something exceptional occurs.

        try
        {
            var text = File.ReadAllText("HelloWorld.txt");  // Trying to read a file that doesn't exist.

            Console.WriteLine(text);
        }
        catch (FileNotFoundException e) // Exceptions will be thrown in order os specificity. In this code only FileNotFoundException will be thrown
        {
            Console.WriteLine("File Not Found Exception");
            Console.WriteLine(e.Message);
        }
        catch (Exception e) // General exception are not advised. Exceptions informs the developer what happened allowing to implement specific types of exceptions.
        {
            Console.WriteLine("Exception");
            Console.WriteLine(e.Message);
        }
        finally // Finally always run regardless if is the try or the catch block that runs
        {
            Console.WriteLine("I'm always run");
        }
    }
}