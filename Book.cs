using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string isbn, string[] authors, DateTime publicationDate, decimal price)
        {
            Title = title;
            ISBN = isbn;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString() => $"ISBN:{ISBN},Title:{Title},V:{Authors},publicationDate:{PublicationDate},Price:{Price}";
    }
}
