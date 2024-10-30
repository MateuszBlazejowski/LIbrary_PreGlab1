using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_preglab1;

namespace Library_preglab1
{
    public interface ILibraryItem
    {
        string Title { get; }
        string Author { get; }

        string GetDetails();
    }
}
