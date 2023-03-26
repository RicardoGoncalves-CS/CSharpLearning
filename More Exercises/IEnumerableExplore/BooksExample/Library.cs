using System.Collections;

namespace BooksExample;

public class Library : IEnumerable<Book>
{
    /* In this implementation Library is just wrapping up a List;
     * A List is a collection in itself so it already has GetEnumerator
     * implemented;
     */
    private List<Book> _books = new List<Book>();

    public void Add(Book book)
    {
        _books.Add(book);
    }

    /* Because we are using the IEnumerable we need to implement GetEnumerator methods
     * There are two methods because one implements the Generic version whilst the
     * other implements the legacy version;
     */
    public IEnumerator<Book> GetEnumerator()
    {
        return new BookEnumerator(this);
        // Because List already implements GetEnumerator we could simply use:
        //return _books.GetEnumerator();
    }

    /* Because of precedence rules the Generic version comes first thus
     * we can simply return GetEnumerator method without processing it as
     * recursive;
     */
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Book this[int idx] => _books[idx];
    public int Count => _books.Count;
}
