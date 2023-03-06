namespace UnitTestLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            /* NOTE: There is some conflicting guidelines regarding U rating as it says that is "Suitable for all" 
             * but is described as suitable for audiences aged 4 or above. For this implementation U rating will be
             * considered as "Suitable for all", including children younger than 4.
             */
            if (ageOfViewer <= 0) throw new ArgumentException("Age must be greater than 0.");

            if (ageOfViewer < 8) return "U films are available.";
            else if (ageOfViewer < 12) return "U and PG films are available.";
            else if (ageOfViewer < 15) return "U, PG, 12A & 12 films are available.";
            else if (ageOfViewer < 18) return "U, PG, 12A, 12 & 15 films are available.";
            else return "All films are available.";
        }
    }
}