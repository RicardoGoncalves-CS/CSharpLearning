using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            StringBuilder sb = new StringBuilder();

            if (num > queue.Count()) num = queue.Count();

            for (int i = 0; i < num; i++)
            {
                if (sb.Length == 0) sb.Append(queue.Dequeue());
                else
                {
                    sb.Append(", " + queue.Dequeue());
                }
            }

            string inQueue = sb.ToString();
            
            return inQueue;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> reverse = new Stack<int>();

            foreach (int num in original) reverse.Push(num);
            
            for (int i = 0; i < reverse.Count; i++)
            {
                original[i] = reverse.Pop();
            }

            return original;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> numCounter = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if (char.IsDigit(c))
                {
                    if (numCounter.ContainsKey(c))
                    {
                        numCounter[c]++;
                    }
                    else
                    {
                        numCounter.Add(c, 1);
                    }
                }
            }

            string result = "";

            foreach(KeyValuePair<char, int> kvp in numCounter)
            {
                result += $"[{kvp.Key}, {kvp.Value}]";
            }

            return result;
        }
    }
}
