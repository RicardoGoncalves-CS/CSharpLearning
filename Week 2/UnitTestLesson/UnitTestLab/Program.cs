namespace UnitTestLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 5)
            {
                result = "U films are available.";
            }
            else if (ageOfViewer < 9)
            {
                result = "U and PG films are available.";
            }
            else if (ageOfViewer < 13)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else if (ageOfViewer < 16)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }

            return result;
        }
    }
}