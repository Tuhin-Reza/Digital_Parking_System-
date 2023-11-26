using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("The Dark Knight Returns", "Frank Miller,", "5555", "Comic", 5);
            b.ShowInfo();
            b.AddBookCopy(5);


            Book b2 = new Book("The Incredible Hulk", "Stan Lee", "6666", "Comic", 3);
            b2.ShowInfo();
            b2.AddBookCopy(4);

            Book.showTotalBookInfo();

            Library lib = new Library("Prothoma","Rajshahi");
            lib.ShowLibInfo();

            lib.AddNewBook(b);
            lib.AddNewBook(b2);
            lib.ShowLibInfo();
            lib.AddNewBookCopy(b, 10);
            lib.ShowLibInfo();
            lib.DeleteBook(b);
            lib.ShowLibInfo();

          

            Console.ReadKey();
        }
    }
}
