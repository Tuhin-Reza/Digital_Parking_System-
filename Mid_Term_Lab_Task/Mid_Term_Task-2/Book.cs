using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Term_Task_2
{
    class Book
    {
        String bookName;
        String bookAuthor;
        String bookId;
        String bookTyp;
        int bookCopy;
        static int bookCounter=0;
        public Book()
        { }
        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)
        {
            this.bookName=bookName;
            this.bookAuthor=bookAuthor;
            this. bookId=bookId;
            this. bookTyp=bookTyp;
            this.bookCopy=bookCopy;
            bookCounter = bookCounter + bookCopy;

        }
        public string Name
        {
            get { return bookName; }
            set { bookName= value; }
        }
        public string Id
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string Author
        {
            get { return bookAuthor; }
            set { bookAuthor= value; }
        }
        public string Type
        {
            get { return bookTyp; }
            set { bookTyp = value; }
        }
        public int Copy
        {
            get { return bookCopy; }
            set { bookCopy = value;
            }
        }
      
        void ShowInfo()
        {
            Console.WriteLine("Book Name      : " + bookName);
            Console.WriteLine("Book Author    : " + bookAuthor);
            Console.WriteLine("Book ID        : " + bookId);
            Console.WriteLine("Book Type      : " + bookTyp);
            Console.WriteLine("Total Book     : " + bookCounter);

        }
        void AddBookCopy(int x )
        {

            bookCounter = bookCounter + x;
        }
        static void showTotalBookInfo()
        {
            for (int i = 0; i < bookCounter; i++)
            {

                Console.WriteLine(bookCounter[i].bookName + "\t\t" + theBooks[i].authorName + "\t\t" +
                        theBooks[i].bookQtyCopy + "\t\t" + theBooks[i].bookQty);

            }









        }
}
