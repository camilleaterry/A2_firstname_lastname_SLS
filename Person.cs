using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class Person 
    {

            private string _firstName;
            private string _lastName;
            private string _address;
            private string _wNum;
            private string _ssn;
            private Book[] _booksCheckedOut;
            private int _numberOfBooksCheckedOut;
            private int _rentLimit;

            public Person()
            {
              
            }



            public Person(string firstName, string lastName, string address, string wNum, string ssn, int rentLimit)
            {
                _firstName = firstName;
                _lastName = lastName;
                Address = address;
                _wNum = wNum;
                _ssn = ssn;
                _booksCheckedOut = new Book[rentLimit];
                RentLimit = rentLimit;
                _numberOfBooksCheckedOut = 0;
               
            }

        public int RentLimit 
        {
            get
            {
                return _rentLimit;
            }
            set
            {
                switch (value)
                {
                    case 5:
                        _rentLimit = value;
                            break;
                    case 3:
                        _rentLimit = value;
                        break;
                    default:
                        break;

                }
               
                _rentLimit = value;
            }
        }

        public string FirstName
        {
            get
            {
                if (!string.IsNullOrEmpty(_firstName))
                    { 
                    return _firstName;
                }
                else {

                    return "No First Name is Set";
                }
            }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    _firstName = value;
                }
            } }

             public string LastName
        {
            get
            {
                if (!string.IsNullOrEmpty(_lastName))
                {
                    return _lastName;
                }
                else
                {
                    return " No Last Name is Set";
                }

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _lastName = value;
                }
            }
        }

        public string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(_firstName) && !string.IsNullOrEmpty(_lastName))
                {
                    return _firstName + " " + _lastName;
                }
                else
                {
                    return "First name and last name not set";
                }
            }
        }


             public string Address
        {
            get
            {
                if (!string.IsNullOrEmpty(_address))
                {
                    return _address;
                }
                else
                {
                    return " No Address is Set";
                }

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _address = value;
                }
            }
        }

             public string SSN
        {
            get
            {
                if (!string.IsNullOrEmpty(_ssn))
                {
                    return _ssn;
                }
                else
                {
                    return " No SSN is Set";
                }

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ssn = value;
                }
            }
        }

             public string wNum
        {
            get
            {
                if (!string.IsNullOrEmpty(_wNum))
                {
                    return _wNum;
                }
                else
                {
                    return " No W Number is Set";
                }

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _wNum = value;
                }
            }
        }

        public bool maxRentedLimit()
        {
            if (_numberOfBooksCheckedOut >= RentLimit)
            {
                return true;
            }
            return false;
        }


        public void CheckOutBook(Book book, Catalog catalog)
        {
            if (!maxRentedLimit())
            {
                for (int i = 0; i < _booksCheckedOut.Length; i++)
                {
                    if (_booksCheckedOut[i] == null)
                    {
                        catalog.CheckOutBook(this, book);
                        //book.MarkIFCheckedOut();
                        _booksCheckedOut[i] = book;
                        _numberOfBooksCheckedOut++;
                        i = _booksCheckedOut.Length;
                    }
                }
            }
            else
            {
                throw new Exception("Student has too many Books Being Rented");
            }
        }

        public void ReturnBook(Book book, Catalog catalog)
        {
            if (book != null && catalog != null && _booksCheckedOut.Any(x => x.GetIsbn() == book.GetIsbn()))
            {
                for (int i = 0; i < _booksCheckedOut.Length; i++)
                {
                    if (_booksCheckedOut[i] != null && _booksCheckedOut[i].GetIsbn() == book.GetIsbn())
                    {
                        catalog.ReturnBook(this, book);
                        _booksCheckedOut[i] = null;
                        _numberOfBooksCheckedOut--;
                        i = _booksCheckedOut.Length;

                    }
                }
            }
        }


        public void PrintUserInfo()
        {
            String s = "";
            if (_booksCheckedOut.Length == 3)
            {
                s = "Student Info";
            }
            else
            {
                s = "Instructor Info";
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine(s);
            Console.WriteLine("Name: " + _firstName + " " + _lastName);
            Console.WriteLine("W#: " + _wNum);
            Console.WriteLine("SSN: " + _ssn);
            Console.WriteLine("-----------------------------");
        }

        public void PrintListOfBooksCheckedOut()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Printing Books Checked Out");
            foreach (Book book in _booksCheckedOut)
            {
                if (book != null)
                {
                    book.PrintBookInfo();
                }

            }
        }

        public Book[] GetBooksCheckedOut()
        {
            return _booksCheckedOut;
        }


        public int NumOfBooksCheckedOut
        {
            get
            {
                int count = 0;
                for (int i = 0; i < _booksCheckedOut.Length; i++)
                {
                    if (_booksCheckedOut[i] != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

    }
}
