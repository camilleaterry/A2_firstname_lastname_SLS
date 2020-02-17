using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class SLS 
    {

        public Catalog _catalog;
        public Librarian _librarian;
        public List<Student> _student;
        public List<Instructor> _instructors;
        public long _numOfStudents;
        public SLS(bool populateLibrary, int numOfBooksOrStud)
        {
            Random rand = new Random();
            int employeeId = rand.Next(1, 1000);
            _catalog = new Catalog(employeeId);
            _librarian = new Librarian("Camille", "Terry", "3848 Harrison Blvd, Ogden, UT 84408", 7654321, employeeId);
            _student = new List<Student>();
            _instructors = new List<Instructor>();

            if (populateLibrary)
            {
                List<Book> books = GetListOfRandomBooks(numOfBooksOrStud);
                foreach (Book b in books)
                {
                    _catalog.AddBook(_librarian, b);
                }
                _student = GetListOfRandomStudents(numOfBooksOrStud);
                _instructors = GetListOfRandomInstructors(numOfBooksOrStud);


            }

           // _numOfStudents = _student.Count();
        }

        public SLS(Librarian librarian)
        {
            _catalog = new Catalog(librarian.GetId());
            _librarian = librarian;
            _student = new List<Student>();
            _instructors = new List<Instructor>();
            _numOfStudents = 0;
        }

        public SLS(Librarian librarian, List<Student> students, List<Instructor> instructors, List<Book> books)
        {
            _catalog = new Catalog(librarian.GetId());
            foreach (Book b in books)
            {
                _catalog.AddBook(librarian, b);
            }
            _librarian = librarian;
            _student = students;
            _instructors = instructors;
        }



        public void AddAStudent(Student student)
        {
            _student.Add(student);
            _numOfStudents = _student.Count();
        }

        public void RemoveAStudent(Student student)
        {
            if (_student.Contains(student))
            {
                _student.Remove(student);
            }
            _numOfStudents = _student.Count();
        }


        public int NumberOfStudents
        {
            get
            {
                return _student.Count;
            }
        }

        public int NumberOfInstructors
        {
            get
            {
                return _instructors.Count;
            }
        }

    

        public List<Student> GetListOfRandomStudents(int n)
        {
            Student s;
            List<Student> students = new List<Student>();
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                s = new Student("Student" + i, "lastName", "123 Street", i.ToString(), (2000 + i).ToString(), "S" + (3000 + i).ToString());
                students.Add(s);
            }

            return students;
        }

        public List<Instructor> GetListOfRandomInstructors(int n)
        {
            Instructor instructor;
            List<Instructor> instructors = new List<Instructor>();
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                instructor = new Instructor("Instructor" + i, "lastName", "123 Street", i.ToString(), (2000 + i).ToString(), "E" + (3000 + i).ToString());
                instructors.Add(instructor);
            }

            return instructors;
        }


        public List<Book> GetListOfRandomBooks(int numBooks)
        {
            Book book;
            List<Book> books = new List<Book>();
            Random rand = new Random();

            for (int i = 0; i < numBooks; i++)
            {
                book = new Book(i, "Book" + i, "author", (1000 + i).ToString(), BookType.art, BookLocation.firstFloor);
                _catalog.AddBook(this._librarian, book);
            }

            return books;
        }

        public List<Student> GetTotalStudents()
        {
            return _student;
        }

        public List<Instructor> GetTotalInstructors()
        {
            return _instructors;
        }
    }
}
