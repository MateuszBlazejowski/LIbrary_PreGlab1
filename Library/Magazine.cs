using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_preglab1
{
    public class Magazine : ILibraryItem
    {
        public string Title { get; }
        public string Author { get; }

        public Magazine(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string GetDetails()
        {
            return $"Magazine {Title} by {Author}.";
        }
    }
}
