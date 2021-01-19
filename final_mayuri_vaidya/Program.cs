using System;
using System.Collections.Generic;

namespace final_mayuri_vaidya
{
    
    class MyGeneric<T> where T : struct
    {
        private List<T> collection;

        public void additem(T t)
        {
            collection.Add(t);
        }

        public T getitem(int index)
        {
            foreach (T t in collection)
            {
                if (collection.FindIndex(t) == index)
                {
                    return t;
                }
            }

        }

        public ICollection<T> Mysort()
        {
            collection.Sort();
            return collection;
        }

    }
}
}
