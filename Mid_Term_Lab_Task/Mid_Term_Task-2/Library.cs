using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Term_Task_2
{
    class Library
    {
        String libName;
        String libAddress;
        Book[] listOfBook;
        int totalBook;
       

        public Library()
        { }
        public Library(String libNameS, String libAddress, Book[] listOfBook, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            listOfBook = new Book[1000];
        }
        public string Name
        {
            set { libName = value; }
            get { return libName; }
        }
        private string Address;
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        void ShowLibInfo() // show library info and all book info as well
        {
            Console.WriteLine("Library  Name      : " + libName);
            Console.WriteLine("Library Address    : " + libAddress);
            foreach (var value in listOfBook)
            {
                Console.WriteLine(value);
            }

        }
        void AddNewBook(Book book) // add a new book into lib
        {
         
            if(totalBook<1000)
            {
                this.listOfBook[totalBook] = book;
                totalBook++;
            }
          else
            {
                Console.WriteLine("Can Not Added New Book");
            }
        }
        void DeleteBook(Book book) // delete book object
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (book == this.listOfBook[i])
                {
                    listOfBook[i] = listOfBook[--totalBook];
                    Console.WriteLine("Deleted");
                }
                else
                {
                    Console.WriteLine("Can Not Deleted Book");
                }
            }

        }
        void AddNewBookCopy(Book book, int copy)
        {
            if (totalBook < 1000)
            {
                this.listOfBook[totalBook] = book;
                totalBook++;
            }
            totalBook = totalBook + copy;
        }
    }
}
