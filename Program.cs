﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfbooks = 10;
            SLS librarySystem = new SLS(true, numOfbooks);
            Student student = librarySystem.GetTotalStudents()[0];
            Instructor instructor = librarySystem.GetTotalInstructors()[1];
            List<Book> books = librarySystem._catalog.GetTotalBooks();
            int milliseconds = 2500;

            Catalog catalog = librarySystem._catalog;
            Console.WriteLine("Library System");
            Console.WriteLine();
            Console.WriteLine("Printing books in system");
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
           
            librarySystem._catalog.PrintBooks();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Printing User Information");
            student.PrintUserInfo();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");

            instructor.PrintUserInfo();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Student " + student.FullName + " will now check out 3 books");
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            student.CheckOutBook(books.ElementAt(0), catalog);
            student.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            student.CheckOutBook(books.ElementAt(1), catalog);
            student.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            student.CheckOutBook(books.ElementAt(2), catalog);
            student.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            //Throws exception as it should
            /*
            student.CheckOutBook(books.ElementAt(3), catalog);
            student.PrintBooksCheckedOut();
            */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Student " + student.FullName + " will now return all books");

            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            student.ReturnBook(books.ElementAt(2), catalog);
            student.PrintListOfBooksCheckedOut();

            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            student.ReturnBook(books.ElementAt(1), catalog);
            student.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            student.ReturnBook(books.ElementAt(0), catalog);
            student.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Instructor " + instructor.FullName + " will now check out 5 books");
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            instructor.CheckOutBook(books.ElementAt(0), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            instructor.CheckOutBook(books.ElementAt(1), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            instructor.CheckOutBook(books.ElementAt(2), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            instructor.CheckOutBook(books.ElementAt(3), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            //Console.ReadLine();

            instructor.CheckOutBook(books.ElementAt(4), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");



            //Console.ReadLine();

            //Throws Exception as it should
            /*
            instructor.CheckOutBook(books.ElementAt(4), catalog);
            instructor.PrintBooksCheckedOut();
            Thread.Sleep(milliseconds);
            */

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Instructor " + instructor.FullName + " will now return books");
            Console.ReadLine();
            Console.WriteLine("press any key to continue"); instructor.ReturnBook(books.ElementAt(4), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");            //Console.ReadLine();

            instructor.ReturnBook(books.ElementAt(3), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");            //Console.ReadLine();

            instructor.ReturnBook(books.ElementAt(2), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");            //Console.ReadLine();

            instructor.ReturnBook(books.ElementAt(1), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");            //Console.ReadLine();

            instructor.ReturnBook(books.ElementAt(0), catalog);
            instructor.PrintListOfBooksCheckedOut();
            Console.ReadLine();
            Console.WriteLine("press any key to continue");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            librarySystem._catalog.PrintBooks();



            Console.WriteLine("Enter any key to quit");
            Console.ReadLine();




            /*
            int numOfBooksOrStud = 5;
            SLS librarySystem = new SLS(true, numOfBooksOrStud);
            Random rand = new Random();
            List<Student> students = librarySystem.GetTotalStudents();
            List<Book> books = librarySystem._catalog.GetTotalBooks();
            Librarian librarian = librarySystem._librarian;
            Student student = students.ElementAt(rand.Next(numOfBooksOrStud));
            bool quit = false;
            String isbn = "";
            String bookIdInput = "";
            String title = "";
            String author = "";
            BookType type = BookType.art;
            BookLocation location = BookLocation.firstFloor;
            long bookID = 0;
            bool checkedOut = false;

            while (!quit)
            {
                Console.WriteLine("****     Welcome to camille Library!!      ******");
                Console.WriteLine();
                Console.WriteLine("Student Mode or Librarian Mode?");
                Console.WriteLine("'1' for Student");
                Console.WriteLine("'2' for Librarian");


                try
                {
                    char key = Console.ReadKey().KeyChar;
                    switch (key)
                    {
                        case '1':

                            Book book;
                            bool loop = true;
                            while (loop)
                            {
                                Console.WriteLine("**************** Student Mode **********************");
                                student.PrintUserInfo();
                                Console.WriteLine("Checking Out or Returning?");
                                Console.WriteLine("'1' for Checking Out");
                                Console.WriteLine("'2' for Returning");
                                key = Console.ReadKey().KeyChar;

                                switch (key)
                                {
                                    case '1':
                                        librarySystem._catalog.PrintBooks();
                                        Console.Write("Type the isbn of the book you want to check out: ");
                                        string input1 = Console.ReadLine();

                                        book = books.Where(x => x.GetIsbn() == input1).FirstOrDefault();
                                        student.CheckOutBook(new Book(book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetIsbn(), book.GetType(), book.GetLocation()), librarySystem._catalog);
                                        Console.WriteLine("Book with ISBN#: " + book.GetIsbn() + " Checked Out!");
                                        Console.WriteLine();
                                        break;
                                    case '2':
                                        student.PrintListOfBooksCheckedOut();
                                        Console.Write("Type the isbn of the book you want to return: ");
                                        string input2 = Console.ReadLine();

                                        book = student.GetBooksCheckedOut().Where(x => x.GetIsbn() == input2).FirstOrDefault();
                                        student.ReturnBook(new Book(book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetIsbn(), book.GetType(), book.GetLocation()), librarySystem._catalog);
                                        Console.WriteLine("Book with ISBN#: " + book.GetIsbn() + " Returned!");
                                        Console.WriteLine();
                                        break;
                                }
                                Console.WriteLine("Continue in Student Mode?");
                                Console.WriteLine("1 for yes");
                                Console.WriteLine("2 for no");
                                char looper = Console.ReadKey().KeyChar;
                                if (looper == '2')
                                {
                                    loop = false;
                                }
                            }
                            break;
                        case '2':

                            Console.WriteLine("**************** Librarian Mode **********************");
                            Console.WriteLine("Librarians Can Add Books to the Catalog");
                            Console.WriteLine();
                            librarySystem._librarian.PrintLibrarianInfo();
                            Console.WriteLine();
                            Console.WriteLine("Enter book info");
                            Console.Write("BookId: ");
                            bookIdInput = Console.ReadLine();
                            bookID = long.Parse(bookIdInput);
                            Console.Write("ISBN #: ");
                            isbn = Console.ReadLine();
                            Console.Write("Title: ");
                            title = Console.ReadLine();
                            Console.Write("Author: ");
                            author = Console.ReadLine();
                            Console.WriteLine("Book Types are as Follows");
                            Console.WriteLine("Science = 1");
                            Console.WriteLine("Arts = 2");
                            Console.WriteLine("Maths = 3");
                            Console.WriteLine("History = 4");
                            Console.WriteLine("Education = 5");
                            Console.WriteLine();
                            Console.Write("Enter Book Type #: ");
                            key = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            switch (key)
                            {
                                case '1':
                                    type = BookType.science;
                                    break;
                                case '2':
                                    type = BookType.art;
                                    break;
                                case '3':
                                    type = BookType.math;
                                    break;
                                case '4':
                                    type = BookType.history;
                                    break;
                                case '5':
                                    type = BookType.education;
                                    break;
                            }

                            book = new Book(bookID, title, author, isbn, type, location);
                            librarySystem._catalog.AddBook(librarySystem._librarian, book);
                            Console.WriteLine(book.GetTitle() + " Successfully Added to the Catalog");
                            Console.WriteLine();

                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.WriteLine();
                }

            }

            */
        }
    }
}




