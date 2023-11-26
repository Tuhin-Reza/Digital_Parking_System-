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


            Book b2 = new Book("The Incredible Hulk", "Stan Lee", "6666", "Comic", 2);
            b2.ShowInfo();
            b2.AddBookCopy(4);

            Book.showTotalBookInfo();

            Library lib = new Library("Prothoma","Rajshahi");
            lib.ShowLibInfo();

            Library lib2 = new Library("Prothoma", "Rajshahi");
            lib2.Name = "Prothoma";
            lib2.ShowLibInfo();

            lib.AddNewBook(b);
           // lib.ShowLibInfo();

            //lib.DeleteBook(b);
           lib.ShowLibInfo();
            lib.AddNewBookCopy(b, 10);
            lib.ShowLibInfo();

            // b.showTotalBookInfo(lib);

            // b2.ShowAllBooks();

            Console.ReadKey();
        }
    }
}
