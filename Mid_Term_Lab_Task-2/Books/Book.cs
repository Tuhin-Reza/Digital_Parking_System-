using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Book
    {
        String bookName;
        String bookAuthor;
        String bookId;
        String bookTyp;
        int bookCopy;
        static int bookCounter = 0;
        public Book()
        { }
        public Book(String bookName, String bookAuthor, String bookId, String bookTyp, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookTyp = bookTyp;
            this.bookCopy = bookCopy;
            bookCounter = bookCounter + bookCopy;
        }
        public string Name
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string Id
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string Author
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public string Type
        {
            get { return bookTyp; }
            set { bookTyp = value; }
        }
        public int Copy
        {
            get { return bookCopy; }
            set
            {
                bookCopy = value;
            }
        }

        public void ShowInfo()
        {

            Console.WriteLine("----------Book Information----------\n");
            Console.WriteLine("Book Name                : " + bookName);
            Console.WriteLine("Book Author              : " + bookAuthor);
            Console.WriteLine("Book ID                  : " + bookId);
            Console.WriteLine("Book Type                : " + bookTyp);
            Console.WriteLine("Total Number of Book     : " + bookCopy+"\n");

        }
        public void AddBookCopy(int x)
        {

            if (x >= 0)
            {
                bookCopy += x;
                bookCounter = bookCounter + x;
                Console.WriteLine("--->Book Copy Added\n");

            }
            else
            {
                Console.WriteLine("--->Cannot Added Book Copy\n");
            }
        }
        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total Book     : " + bookCounter + "\n");
        }
        
    }
}  