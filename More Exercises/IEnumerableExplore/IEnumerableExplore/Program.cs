namespace IEnumerableExplore;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int> { 3, 4, 6, 11, 20, 9, 17 };

        {
            // All collections have the GetEnumerator method
            IEnumerator<int> en = ints.GetEnumerator();

            /* Using the IEnumerator to iterate over ints:
             * 
             * This will have the same result as a foreach.
             * 
             * MoveNext moves the pointer to the next element and 
             * returns a bool indication whether or not there is
             * a next element in the collection.
             * 
             * Current represents the current value being pointed to.
             */

            while (en.MoveNext()) Console.WriteLine(en.Current);
        }

        Console.WriteLine();

        foreach (var num in ints) Console.WriteLine(num);
    }
}