using System.Linq;

namespace BooksExample;

internal class Program
{
    static void Main()
    {
        /* We can initialise our library because the Library class
         * implements the IEnumerable interface and has an Add method;
         */
        Library library = new Library()
        {
            new Book { Title = "Dr no", Author = "Ian Fleming" },
            new Book { Title = "Emma", Author = "Jane Austen" },
            new Book { Title = "Goldfinger", Author = "Ian Fleming" },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen" }
        };

        // Without implementing the GetEnumerator method we cannot use a foreach loop
        for(int i = 0; i < library.Count; i++) Console.WriteLine(library[i]);

        Console.WriteLine();

        /* Because the IEnumerator have been implemented in 
         * the Library class we can now use the foreach loop 
         * to iterate over this collection;
         * 
         * We can also use Linq to work with the collection:
         * In the example below we skip the first element and
         * return the next two elements in the colleciton and
         * then reverses it;
         */
        foreach (var book in library.Skip(1).Take(2).Reverse()) 
            Console.WriteLine(book);

        Console.WriteLine();

        // Example of filtering the results using Linq:
        foreach(var b in library.Where(b => b.Author.EndsWith("Fleming")))
            Console.WriteLine(b);

        Console.WriteLine();

        // In this example Max will give us the last in alphabetic order
        Console.WriteLine(library.Max(b => b.Author));
    }
}