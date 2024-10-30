using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_preglab1; 

namespace Library_preglab1
{
    internal class Book : ILibraryItem
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string GetDetails()
        {
            return $"Book {Title} by {Author}.";
        }
    }
}
