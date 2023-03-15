using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager.Model
{
    public class ArrayBuilder
    {
        public static int[] GenArray(int lengthOfTheArray)
        {
            Random rand = new Random();
            int[] randomArray = new int[lengthOfTheArray];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(-100, 100);
            }
            return randomArray;
        }
    }
}
