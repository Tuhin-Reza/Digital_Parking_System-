 using System;

namespace Using_base_key
{
    public class web
    {
        string name = "GeeksForGeeks";
        // 'showdata()' is member method,
        // declare as virtual
        public virtual void showdata()
        {
            Console.WriteLine("Website Name: " + name);
        }
    }
    // derived class
    // class 'web' is inherits
    // class 'stream'
    class stream : web
    {
        string s = "Computer Science";
        //'showdata()' is overridden
        // in derived class
        public override void showdata()
        {
            // Calling 'showdata()' of base
            // class using 'base' keyword
            base.showdata();

            Console.WriteLine("About: " + s);
        }
    }

    class GFG
    {
        static void Main()
        {
            // 'E' is object of class stream
            // also works as object of 
            // class 'web'
            stream E = new stream();


            // it first invokes 'showdata()'
            // of class 'web' then it invokes 
            // 'showdata()' of class 'stream'
            E.showdata();

        }
    }
}
