using System;

namespace ConsoleApp1
{
    public class Book 
    {  
      public string BookName { get;
            set;
        }
       public string Id
        {
            get;
            set;
        }

         void Display()
        {
            Console.WriteLine("bookname: {0}", BookName);
            
        }
    }
}
