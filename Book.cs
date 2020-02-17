using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{

    public enum BookType
    {
        science = 0,
        art = 1,
        math = 2,
        history = 3,
        education = 4
    }

    public enum BookLocation
    {
        firstFloor = 0,
        secondFloor = 1,
        thirdFloor = 2
    }

    public class Book
    {
        private long _bookId;
        private string _bookTitle;
        private string _author;
        private string _isbn;
        private BookType _type;
        private BookLocation _location;
        private bool _checkedOut;

        private DateTime _checkOutDate;
        private DateTime _returnDate;

     

        public Book()
        {

        }

        public Book(long bookId, string title, string author, string isbn, BookType type, BookLocation location)
        {
            _bookId = bookId;
            _bookTitle = title;
            _author = author;
            _isbn = isbn;
            _type = type;
            _location = location;
            _checkedOut = false;
        }

        public DateTime CheckoutDate
        {
            get
            {
                return _checkOutDate;
            }
            set
            {
                _checkOutDate = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return _returnDate;
            }
            set
            {
                _returnDate = value;
            }
        }

        public long GetBookId()
        {
            return _bookId;
        }

        public string GetTitle()
        {
            return _bookTitle;
        }

        public string GetAuthor()
        {
            return _author;
        }


        public BookType GetType()
        {
            return _type;
        }

        public BookLocation GetLocation()
        {
            return _location;
        }


        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

        public void MarkIFCheckedOut()
        {
            if (!_checkedOut)
            {
                _checkedOut = true;
                //CheckoutDate = DateTime.Today;
         
            }
            else
            {
                throw new Exception("The Book you picked is already checked out, now redirecting back to main page");
            }
        }

        public void MarkWhenReturned()
        {
            if (_checkedOut)
            {
                _checkedOut = false;
                ReturnDate = new DateTime();
                CheckoutDate = new DateTime();
                
            }
            else
            {
                throw new System.InvalidOperationException();
            }
        }


        public void PrintBookInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("BookId: " + _bookId);
            Console.WriteLine("Title: " + _bookTitle);
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("ISBN: " + _isbn);
            Console.WriteLine("Type: " + _type);
            Console.WriteLine("Location: " + _location);
            Console.WriteLine("Checked Out: " + _checkedOut);
            Console.WriteLine("------------------------------------------");
        }

        public string GetIsbn()
        {
            return _isbn;
        }

        public bool MatchIsbn(Book b)
        {
            return _isbn == b.GetIsbn();
        }
    }
}
