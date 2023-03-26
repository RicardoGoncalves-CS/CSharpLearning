using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace BooksExample;

public class BookEnumerator : IEnumerator<Book>
{
    /* This class exemplifies how to implement an Enumerator;
     * This is not strictly necessary in this case because we could
     * simply use the GetEnumerator method from the List in Library;
     */
    private Library _library;
    private int _idx;

    public BookEnumerator(Library library)
    {
        _library = library;
        /* The IEnumerator MoveNext starts by moving to the 
         * next element in the collection thus we need to 
         * start at index -1 so the next element is the one
         * at index 0;
         */
        _idx = -1;
    }

    public Book Current => _library[_idx];

    /* This is the legacy Current. We can simply return the 
     * newer version of current because Book is derived from object;
     */
    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        /* MoveNext moves to the next element by incrementing 
         * the index and returns a bool indicating if there are 
         * more elements in the collection;
         */
        return ++_idx < _library.Count;
    }

    public void Reset()
    {
        _idx = -1;
    }
}