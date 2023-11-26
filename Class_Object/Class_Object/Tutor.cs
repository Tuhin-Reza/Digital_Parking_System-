/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Tutor
    {
        int TutorID;
        string TutorName;

        public void SetTutor(int id, string name)
        {
            TutorID = id;
            TutorName = name;
        }
        public int GetTutorID()
        {
            return TutorID;
        }
        public string GetTutorName()
        {
            return TutorName;
        }
        static void Main(string[] args)
        {
            Tutor t = new Tutor();
            t.SetTutor(101,"K.B.M");
            t.GetTutorID();
            Console.WriteLine(t.GetTutorID());
            Console.WriteLine(t.GetTutorName()+" sir");
            Console.ReadKey();
        }
    }
}*/
using System;

namespace Library_Management
{
    public class Book
    {
        private String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        public int bookCopy;
        public static int bookCounter = 0;

        public Book()
        {

        }

        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }

        public void setbookName(String bookName)
        {
            this.bookName = bookName;
        }

        public void setbookAuthor(String bookAuthor)
        {
            this.bookAuthor = bookAuthor;
        }

        public void setbookId(String bookId)
        {
            this.bookId = bookId;
        }

        public void setbookType(String bookType)
        {
            this.bookType = bookType;
        }

        public void setbookCopy(int bookCopy)
        {
            this.bookCopy = bookCopy;
        }

        public String getbookName()
        {
            return this.bookName;
        }

        public String getbookAuthor()
        {
            return this.bookAuthor;
        }

        public String getbookId()
        {
            return this.bookId;
        }

        public String getbookType()
        {
            return this.bookType;
        }

        public int getbookCopy()
        {
            return this.bookCopy;
        }
        public void showInfo()
        {
            bookCounter++;
            Console.WriteLine("Book Name:" + getbookName());
            Console.WriteLine("Author:" + getbookAuthor());
            Console.WriteLine("Book ID:" + getbookId());
            Console.WriteLine("Book Type:" + getbookType());
            Console.WriteLine("Number of Copies:" + getbookCopy());
        }


        public void AddBookCopy(int x)
        {
            if (x >= 0)
            {
                this.bookCopy += x;
                Console.WriteLine("Successfully Added");
            }
            else
            {
                Console.WriteLine("Amount can not be zero");
            }
        }

        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total Number of Books:" + bookCounter);

        }
    }

    public class Library
    {
        private String libName;
        private String libAddress;
        private Book[] listofBook = new Book[100];
        private int totalBook;

        public Library()
        {

        }

        public Library(String libName, String libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
        }

        public void setlibName(String libName)
        {
            this.libName = libName;
        }

        public void setlibAddress(String libAddress)
        {
            this.libAddress = libAddress;
        }

        public void settotalBook(int totalBook)
        {
            this.totalBook = totalBook;
        }

        public String getlibName()
        {
            return this.libName;
        }

        public String getlibAddress()
        {
            return this.libAddress;
        }

        public int gettotalBook()
        {
            return this.totalBook;
        }

        public void AddNewBook(Book book)
        {
            bool inserted = false;
            for (int i = 0; i < listofBook.Length; i++)
            {
                if (listofBook[i] == null)
                {
                    listofBook[i] = book;
                    totalBook += listofBook[i].bookCopy;
                    inserted = true;
                    Console.WriteLine("Book Inserted");
                    break;
                }
            }
            return;
        }

        public void DeleteBook(Book book)
        {
            bool deleted = false;
            for (int i = 0; i < listofBook.Length; i++)
            {
                if (listofBook[i].getbookId().Equals(book.getbookId()))
                {
                    totalBook -= listofBook[i].bookCopy;
                    listofBook[i] = null;
                    deleted = true;
                    break;
                }
            }
            if (deleted)
            {
                Console.WriteLine("Book Deleted!!");
            }
            else
            {
                Console.WriteLine("No Employee Found");
            }
            return;
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            bool updated = false;
            for (int i = 0; i < listofBook.Length; i++)
            {
                if (listofBook[i] != null)
                {
                    if (listofBook[i].getbookId().Equals(book.getbookId()))
                    {
                        listofBook[i].bookCopy += copy;
                        totalBook += copy;
                        updated = true;
                        break;
                    }
                }
            }
        }

        public void showlibInfo()
        {
            Console.WriteLine("Libray Name:" + getlibName());
            Console.WriteLine("Library Address:" + getlibAddress());
            for (int i = 0; i < listofBook.Length; i++)
            {
                if (listofBook[i] != null)
                {
                    Console.WriteLine("Total Number of books in the library:" + totalBook);
                    Console.WriteLine("Book Name:" + listofBook[i].getbookName());
                    Console.WriteLine("Author:" + listofBook[i].getbookAuthor());
                    Console.WriteLine("Book ID:" + listofBook[i].getbookId());
                    Console.WriteLine("Book Type:" + listofBook[i].getbookType());
                    Console.WriteLine("Number of Copies:" + listofBook[i].getbookCopy());
                    Console.WriteLine();
                }
            }
        }

    }
    class Start
    {

        static void Main(string[] args)
        {
            int choice;
            Library lib = new Library();
            Console.WriteLine("Welcome to Library Management");
            do
            {
                Console.WriteLine("Welcome to the menu,");
                Console.WriteLine("[1]-Add Book");
                Console.WriteLine("[2]-Delete Book");
                Console.WriteLine("[3]-Update Book Quantity");
                Console.WriteLine("[4]-Show All Books");
                Console.WriteLine("[5]-Enter the Libray Info");
                Console.WriteLine("[6]-Exit the Menu");
                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter Book Name:");
                            String name = Console.ReadLine();
                            Console.Write("Enter the Author Name:");
                            String author = Console.ReadLine();
                            Console.Write("Enter Book ID:");
                            String id = Console.ReadLine();
                            Console.Write("Enter Book Type:");
                            String type = Console.ReadLine();
                            Console.Write("Enter the number of Copies:");
                            int copy = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(name, author, id, type, copy);
                            lib.AddNewBook(book);
                            Console.Clear();
                            break;
                            
                        }

                    case 2:
                        {
                            Console.Write("Enter Book Name:");
                            String name = Console.ReadLine();
                            Console.Write("Enter the Author Name:");
                            String author = Console.ReadLine();
                            Console.Write("Enter Book ID:");
                            String id = Console.ReadLine();
                            Console.Write("Enter Book Type:");
                            String type = Console.ReadLine();
                            Console.Write("Enter the number of Copies:");
                            int copy = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(name, author, id, type, copy);
                            lib.DeleteBook(book);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Please Enter already included book details");
                            Console.Write("Enter Book Name:");
                            String name = Console.ReadLine();
                            Console.Write("Enter the Author Name:");
                            String author = Console.ReadLine();
                            Console.Write("Enter Book ID:");
                            String id = Console.ReadLine();
                            Console.Write("Enter Book Type:");
                            String type = Console.ReadLine();
                            Console.Write("Enter the number of Copies:");
                            int copy = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(name, author, id, type, copy);
                            Console.Write("Enter the number of Copies you want to add:");
                            int add = Convert.ToInt32(Console.ReadLine());
                            lib.AddNewBookCopy(book, add);
                            break;
                        }

                    case 4:
                        {
                            lib.showlibInfo();
                            break;
                        }

                    case 5:
                        {
                            Console.Write("Enter Libray Name:");
                            String libname = Console.ReadLine();
                            Console.Write("Library Address:");
                            String address = Console.ReadLine();
                            lib.setlibName(libname);
                            lib.setlibAddress(address);
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("==============================");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Wrong Choice:");
                            break;
                        }
                }

            } while (choice != 6);
            {
                Console.WriteLine("Thanks for Using");
            }
        }
    }
}

