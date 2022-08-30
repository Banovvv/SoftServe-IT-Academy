using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftServe_IT_Academy.Practice._IEnumerable__IEnumerator_interfaces
{
    public class Book
    {
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
    }

    public class Library : IEnumerable<Book>
    {
        public IEnumerable<Book> Books { get; }
        public Predicate<Book> Filter { get; internal set; }
        public Library(IEnumerable<Book> book)
        {
            Books = book;
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new MyEnumerator(Books, Filter);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public sealed class MyEnumerator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentIndex = -1;

        public MyEnumerator(IEnumerable<Book> library, Predicate<Book> filter)
        {
            if (filter != null)
            {
                books = new List<Book>(library).FindAll(filter);
            }
            else
            {
                books = new List<Book>(library);
            }
        }

        public Book Current => books[currentIndex];
        object IEnumerator.Current => Current;
        public void Dispose() { }
        public bool MoveNext() => ++currentIndex < books.Count;
        public void Reset() => currentIndex = -1;
    }

    public class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> library, Predicate<Book> predicate)
        {
            var lib = new Library(library) { Filter = predicate };

            List<Book> books = new List<Book>();

            foreach (var item in lib)
            {
                if (predicate(item))
                {
                    books.Add(item);
                }
            }

            return books;
        }
    }
}
