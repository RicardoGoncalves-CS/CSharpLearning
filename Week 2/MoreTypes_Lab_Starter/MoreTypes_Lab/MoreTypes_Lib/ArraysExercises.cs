using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] strArr = new string[contents.Count];

            for (int i = 0; i < contents.Count; i++)
            {
                strArr[i] = contents[i];
            }

            return strArr;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            try
            {
                int counter = 0;

                string[,,] str3D = new string[length1, length2, length3];

                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        for (int k = 0; k < length3; k++)
                        {
                            str3D[i, j, k] = contents[counter];
                            counter++;
                        }
                    }
                }

                return str3D;
            }
            catch
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            try
            {
                int contentsCounter = 0;
                int index = 0;
                int rowCounter = countRow1;

                string[][] jaggedArr = new string[2][];

                jaggedArr[0] = new string[countRow1];
                jaggedArr[1] = new string[countRow2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < rowCounter; j++)
                    {
                        jaggedArr[index][j] = contents[contentsCounter];
                        contentsCounter++;
                    }
                    rowCounter = countRow2;
                    index++;
                }
                return jaggedArr;
            }
            catch
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
        }
    }
}
