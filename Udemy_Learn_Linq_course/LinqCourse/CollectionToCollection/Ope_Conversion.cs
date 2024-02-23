using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Conversion
    {
        public void Methode()
        {
            int[] entiers = new int[6] { 1, 2, 3, 4, 5, 1 };
            var entiersEnumerable = entiers.AsEnumerable();
            var entiersQueryable = entiers.AsQueryable();
            var entiersMemory = entiers.AsMemory();
            var entiersSpan = entiers.AsSpan();

            var objects = new object[] { 1, 2, "abc", "def" };
            var entiers2 = objects.OfType<string>();

            foreach (var item in entiers2)
            {
                Console.WriteLine(item);
            }

            //var entiers3 = objects.Cast<int>();
            //foreach (var item in entiers3)
            //{
            //    Console.WriteLine(item);
            //}

            //Methode2(entiers);
        }

        public void Methode2(IEnumerable<int> ints)
        {
            var tabEntiers = ints.ToArray();
            var listEntiers = ints.ToList();

            Console.WriteLine("Dictionary");
            //var dictionary = ints.ToDictionary(k => k.ToString(), v => v * v);
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key} = {item.Value}");
            //}

            Console.WriteLine("Lookup");
            var lookup = ints.ToLookup(k => k.ToString(), v => v * v);
            foreach (var item in lookup)
            {
                Console.WriteLine($"Élements avec la clé{item.Key}");
                foreach (var value in item)
                {
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine("Hashset");
            var hashset = ints.ToHashSet();
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
