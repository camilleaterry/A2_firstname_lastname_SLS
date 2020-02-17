using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class Librarian
    {


        private string _firstName;
        private string _lastName;
        private string _address;
        private long _ssn;
        private long _employeeId;


        public Librarian()
        {

        }

        public Librarian(string firstName, string lastName, string address, long ssn, long employeeId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _ssn = ssn;
            _employeeId = employeeId;

        }

        public long GetId()
        {
            return _employeeId;
        }

        public void AddABook(Catalog catalog, Book book)
        {
            catalog.AddBook(this, book);
        }

        public void RemoveBook(Catalog catalog, Book book)
        {
            catalog.RemoveBook(this, book);
        }

        public void PrintLibrarianInfo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Printing Librarian Info");
            Console.WriteLine("Name: " + _firstName + " " + _lastName);
            Console.WriteLine("Address: " + _address);
            Console.WriteLine("SSN: " + _ssn);
            Console.WriteLine("EmplyeeId: " + _employeeId);
        }

    }
}
