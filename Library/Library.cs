using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_preglab1
{
    public class Library<T> : IEnumerable<T> where T : ILibraryItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void Clear() { items.Clear(); }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items) {
                yield return item;
            }
          
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //public IEnumerable<T> GetItems()
        //{
        //    foreach (T item in items)
        //    {
        //        yield return item;
        //    }
        //}
        //useless, is the same as public IEnumerator<T> GetEnumerator() but requires .GetItems to be used
    }
}
