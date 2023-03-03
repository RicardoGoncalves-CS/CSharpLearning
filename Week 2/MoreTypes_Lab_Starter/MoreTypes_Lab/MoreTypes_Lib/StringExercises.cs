using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string numericString = "";

            for (int i = 0; i < num; i++)
            {
                numericString += i;
            }

            return input.Trim().ToUpper() + numericString;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }

        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {Math.Round((float)score*100/outOf, 1)}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            if (Double.TryParse(numString, out double num)) return num;
            else return -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            input = input.ToUpper();

            foreach(char letter in input)
            {
                if (letter == 'A') countA += 1;
                if (letter == 'B') countB += 1;
                if (letter == 'C') countC += 1;
                if (letter == 'D') countD += 1;
            }

            return $"A:{countA} B:{countB} C:{countC} D:{countD}";
        }
    }
}
