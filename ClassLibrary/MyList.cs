using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class MyList : IList<MyItem>
    {
        List<MyItem> myItem = new List<MyItem>();
        public MyItem this[int index]
        {
            get
            {
                return myItem[index];
            }
            set
            {
                myItem[index] = value;
            }
        }
        public int Count
        {
            get { return myItem.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(MyItem item)
        {
            myItem.Add(item);
        }

        public void Clear()
        {
            myItem.Clear();
        }

        public bool Contains(MyItem item)
        {
            return myItem.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            myItem.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return myItem.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return myItem.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            myItem.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return myItem.Remove(item);
        }

        public void RemoveAt(int index)
        {
            myItem.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
