using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SortManager.Model;

namespace SortManager
{
    public class Controller
    {
        public static void start()
        {
            int arraySize = View.AskArraySize();

            int[] ary = ArrayBuilder.GenArray(arraySize);

            View.PrintArray(ary);

            bool rev = View.Reverse();

            Sorter a = SorterFactory.CreateSorter(View.AskSortAlgor());

            var output = a.Sort(ary);

            

            if (rev)
            {
                output = output.Reverse().ToArray();
                View.PrintArray(output);
            } else
            {
                View.PrintArray(output);
            }

            

            View.PrintMS(a.GetMilliseconds());

            View.PrintTick(a.GetTicks());

        }
    }
}
