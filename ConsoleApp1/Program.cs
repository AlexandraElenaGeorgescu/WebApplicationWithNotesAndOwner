using System;
using VisioForge.Shared.MediaFoundation.OPM;

namespace ConsoleApp1
{
    class MeetManager
    {
        static void Main(string[] args)
        {   
            string ok = "go";
            Book book = new Book();
            book.
            Author a = new Author();
            while (c.Comparation(ok) != false)
            { b.Acceptdetails1();
                a.Acceptdetails2();
                b.Display();
                a.Display();
               ok = Console.ReadLine();
            }
        }
    }
      public class Author 
    {    
        

        public void Display()
        {
            Console.WriteLine("authorname: {0}", authorname);

        }

    }
  class Get
    {
        protected string bookname;
        protected string authorname;

        public void Acceptdetails1()
        { 
            bookname = Console.ReadLine();

        }
        public void Acceptdetails2()
        {
            authorname = Console.ReadLine();
        }
    }
}
