using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> multipleOfFive = new List<int>();

            if (max == 0) multipleOfFive.Clear();

            for (int i = 0; i <= max; i++)
            {
                if(i % 5 == 0 && i != 0)
                {
                    multipleOfFive.Add(i);
                }
            }

            if (multipleOfFive.Count == 0) multipleOfFive.Clear();

            return multipleOfFive;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> stringsStartingWithA = new List<string>();

            if (sourceList.Count == 0) stringsStartingWithA.Clear();

            foreach(string input in sourceList)
            {
                if (input.ToUpper().StartsWith('A')) stringsStartingWithA.Add(input);
            }

            return stringsStartingWithA;
        }
    }
}
