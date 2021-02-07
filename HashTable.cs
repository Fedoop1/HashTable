using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTable()
        {
            items = new List<TValue>[100];
        }

        public void Add(TKey key, TValue value)
        {
            int k = GetHashKey(key);
            if(items[k] == null)
            {
                items[k] = new List<TValue> { value };
            }
            else
            {
                items[k].Add(value);
            }    
                       
        }

        public bool Search(TKey key, TValue value)
        {
            int k = GetHashKey(key);
            return items[k]?.Contains(value) ?? false;
        }

        private int GetHashKey(TKey key)
        {
            return key.ToString().Length % 100;
        }
    }
}
