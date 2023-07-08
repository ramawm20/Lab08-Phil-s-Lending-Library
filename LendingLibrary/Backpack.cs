using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> BagList;

        public Backpack()
        {
            BagList = new List<T>();
        }

       

        public void Pack(T item)
        {
            if (item != null)
            {
                BagList.Add(item);
            }
        }

        public T Unpack(int index)
        {
            T removed = BagList[index];
            BagList.RemoveAt(index);
            return removed;

        }
        public IEnumerator<T> GetEnumerator()
        {
            return BagList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
