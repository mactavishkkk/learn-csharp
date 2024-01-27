using System;

namespace PrimeiroProjeto
{
    class HashSorted
    {
        static void MainOff(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("faca");
            set.Add("garfo");
            set.Add("colher");

            //Console.WriteLine("'Faca' está presente no conjunto A? " + set.Contains("faca"));

            //foreach (string str in set)
            //{
            //    Console.WriteLine(str);
            //}

            SortedSet<int> A = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> B = new SortedSet<int>() { 1, 2, 5, 6, 8, 12 };

            // Union
            SortedSet<int> C = new SortedSet<int>(A);
            C.UnionWith(B);

            PrintCollection(A);
            PrintCollection(B);
            PrintCollection(C);

            // Intersection
            SortedSet<int> D = new SortedSet<int>(A);
            D.IntersectWith(B);

            PrintCollection<int>(D);
            
            // Difference
            SortedSet<int> E = new SortedSet<int>(A);
            E.ExceptWith(B);

            PrintCollection<int>(E);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}