using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class BookFunction
    {
        public static string GetTitle(Book title) {  return title.Title; }
        public static string GetAuthor(Book[] Author) {  return Author[0].Title; }
        public static string GetPrice(Book price) { return price.ToString(); }
        public static string GetISBN(Book ISBN) {  return ISBN.ToString(); }
        public static DateTime GetPublicationDate(Book PublicationDate) { return PublicationDate.PublicationDate; }

    }
}
