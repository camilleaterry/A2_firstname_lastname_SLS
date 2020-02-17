using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class Catalog
    {

        private List<Book> _books;
        private long _numOfBooks;
        private long _staffPassKey;
        public Catalog()
        {
            _books = new List<Book>();
            _numOfBooks = 0;
        }

        public Catalog(long key)
        {
            _books = new List<Book>();
            _numOfBooks = 0;
            _staffPassKey = key;
        }

        public void AddBook(Librarian librarian, Book book)
        {
            if (AuthorizedStaff(librarian))
            {
                if (book != null && !_books.Any(x => x.GetIsbn() == book.GetIsbn()))
                {
                    _books.Add(new Book(book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetIsbn(), book.GetType(), book.GetLocation()));
                    _numOfBooks = _books.Count();
                }
                else
                {
                    Exception ex = new Exception("Can not add a book that already exists or a null book");
                    throw ex;
                }
            }

        }

        public void RemoveBook(Librarian librarian, Book book)
        {
            if (AuthorizedStaff(librarian))
            {
                if (book != null && _books.Any(x => x.GetIsbn() == book.GetIsbn()))
                {
                    _books.Remove(book);
                    _numOfBooks = _books.Count();
                }
                else
                {
                    Exception ex = new Exception("Can not remove a book that does not exist");
                    throw ex;
                }
            }

        }

        public bool AuthorizedStaff(Librarian librarian)
        {
            if (librarian.GetId() == _staffPassKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckOutBook(Person student, Book book)
        {
            if (book != null && student != null && _books.Any(x => x.GetIsbn() == book.GetIsbn()) && !student.maxRentedLimit())
            {
                foreach (Book b in _books)
                {
                    if (b.MatchIsbn(book))
                    {
                        b.MarkIFCheckedOut();
                    }
                }
            }
        }

        public void ReturnBook(Person student, Book book)
        {
            if (book != null && student != null && _books.Any(x => x.GetIsbn() == book.GetIsbn()))
            {
                foreach (Book b in _books)
                {
                    if (b.MatchIsbn(book))
                    {
                        b.MarkWhenReturned();
                    }
                }
            }
        }

        public void PrintBooks()
        {
            Console.WriteLine("Printing all Books in Catalog");
            foreach (Book books in _books)
            {
                books.PrintBookInfo();
            }
        }

        public List<Book> GetTotalBooks()
        {
            return _books;
        }
    }
}

