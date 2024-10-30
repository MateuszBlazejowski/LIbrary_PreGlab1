#define Stage01
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_preglab1;

    public class Program
    {
        public static void Main()
        {


#if Stage01
        var library = new Library<ILibraryItem>();
        library.AddItem(new Book("1984", "George Orwell"));
        library.AddItem(new Magazine("Time", "Various"));

        foreach (var item in library)
        {
            Console.WriteLine(item.GetDetails());
        }
#endif //Stage01
        }
    }

