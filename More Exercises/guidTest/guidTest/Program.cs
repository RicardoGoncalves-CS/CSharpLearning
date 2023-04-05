using System.Text.RegularExpressions;

namespace guidTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            string guidString = guid.ToString();
            string lettersString = Regex.Replace(guidString, "[0-9]", "").Replace("-", "").Substring(0, 5).ToUpper();

            Console.WriteLine(lettersString);
        }
    }
}