using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace Delegate
{
    public delegate string BookFunctions(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> myBook= new List<Book> ()
            
            {
          new Book("Advanced C#",
                "67890",
                new string[] { "Jane Smith" },
                new DateTime(2020, 10, 5),
                43.9m),
                new Book("C# Programming",
                "12345",
                new string[] { "John Doe" },
                new DateTime(2020, 1, 1),
                49.99m)
            }; ;


            

            LibraryEngine.ProcessBooks(myBook, BookFunction.GetTitle);
            LibraryEngine.ProcessBooks(myBook, BookFunction.GetPrice);
            LibraryEngine.ProcessBooks(myBook, delegate(Book book) {return book.ISBN; });
            LibraryEngine.ProcessBooks(myBook, book => book.PublicationDate.ToShortDateString());

        }
    }
}
