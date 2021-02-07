using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Item<T>
    {
        private int key { get; set; }
        public List<T> Node { get; set; }

        public Item(int key)
        {
            this.key = key;
            Node = new List<T>();
        }
    }
}
