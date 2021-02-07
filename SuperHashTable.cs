using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class SuperHashTable<T>
    {
        private Item<T>[] items;

        public SuperHashTable()
        {
            items = new Item<T>[100];
            for (int index = 0; index < 100; index++)
            {
                items[index] = new Item<T>(index);
            }
        }

        public void Add(T data)
        {
            int key = GetHashCode(data);
            items[key].Node.Add(data);
        }

        public bool Search(T data)
        {
            int key = GetHashCode(data);
            return items[key].Node.Contains(data);
        }

        private int GetHashCode(T data)
        {
            return data.GetHashCode() % 100;
        }
    }
}
