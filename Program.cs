using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHashTable<Person> superHashTable = new SuperHashTable<Person>();

            Person p1 = new Person("Nikita", 17, 0);
            Person p2 = new Person("Alex", 20, 0);
            superHashTable.Add(new Person("Vika", 16, 1));
            superHashTable.Add(p1);
            superHashTable.Add(p2);

            Console.WriteLine(superHashTable.Search(p1));
            Console.WriteLine(superHashTable.Search(p2));
            Console.WriteLine(superHashTable.Search(new Person("Vika", 16, 1)));
            Console.WriteLine((superHashTable.Search(new Person("Unknown", 99, 2))));

            Console.ReadLine();

            HashTable<int, string> hashTable = new HashTable<int, string>();

            hashTable.Add(1, "Андрей");
            hashTable.Add(12, "Никита");
            hashTable.Add(1, "Алексей");

            Console.WriteLine(hashTable.Search(1, "Алексей"));
            Console.WriteLine(hashTable.Search(1, "Андрей"));
            Console.WriteLine(hashTable.Search(12, "Никита"));
            Console.WriteLine(hashTable.Search(15, "Unknown"));

            Console.ReadLine();
        }
    }
}
