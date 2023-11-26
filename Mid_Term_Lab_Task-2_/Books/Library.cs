using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Library
    {
        String libName;
        String libAddress;
        Book[] listOfBook;
        int totalBook=0;
        public Library()
        { }
        public Library(String libName, String libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            listOfBook = new Book[1000];
        }
        public string Name
        {
            set { libName = value; }
            get { return libName; }
        }
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        /*public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }*/
        public void ShowLibInfo() // show library info and all book info as well
        {
            Console.WriteLine("\n----------Library Information----------\n");
            Console.WriteLine("Library Name     : " + libName);
            Console.WriteLine("Library Address  : " + libAddress);
            for (int i = 0; i < totalBook;i++)
            {
                //Console.WriteLine("Book Serial No   : " + i+1);
                Console.WriteLine("Book Name        : " + listOfBook[i].Name);
                Console.WriteLine("Book Author      : " + listOfBook[i].Author);
                Console.WriteLine("Book ID          : " + listOfBook[i].Id);
                Console.WriteLine("Book Type        : " + listOfBook[i].Type);
                Console.WriteLine("Total Copy       : " + listOfBook[i].Copy + "\n");

            }
            Console.WriteLine("Total Book        : " + totalBook);

        }
        public void AddNewBook(Book book) // add a new book into lib
        {

            if (totalBook < 1000)
            {
                listOfBook[totalBook] = book;
                Console.WriteLine("\nAdded New Book ID:"+ listOfBook[totalBook].Id);
                totalBook++;
            }
            else
            {
                Console.WriteLine("Can Not Added New Book");
            }
        }
       public  void DeleteBook(Book book) // delete book object
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (book == listOfBook[i])
                {
                    listOfBook[i] = listOfBook[--totalBook];
                    Console.WriteLine("\n----------Deleted----------\n");
                }
                else
                {
                    Console.WriteLine("Can Not Deleted Book");
                }
            }

        }
        public void AddNewBookCopy(Book book, int copy)
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (book == listOfBook[i])
                {
                    listOfBook[i].Copy =listOfBook[i].Copy+copy;
                   // totalBook += copy;
                    Console.WriteLine("Added Copy Of Book Id : "+ listOfBook[i].Id);
                }
                else
                {
                    Console.WriteLine("Can Not Added Book Copy");
                }
            }
          
        }
    }
}
