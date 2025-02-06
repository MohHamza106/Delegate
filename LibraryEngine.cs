using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    internal class LibraryEngine
    {
        public static void ProcessBooks( List<Book> blist,Func<Book,string> fptr)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(fptr(book));
            }

        }
    }
}
