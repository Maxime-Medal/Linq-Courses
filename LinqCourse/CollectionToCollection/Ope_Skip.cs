using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    internal class Ope_Skip
    {
        internal void Methode()
        {
            int[] entiers = new int[8] { 1, 2, 3, 4, 5, 1, 2, 7 };

            Console.WriteLine("Skip(2)");
            var last5 = entiers.Skip(2);

            foreach (var item in last5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("SkipLast(2)");
            var first5 = entiers.SkipLast(2);

            foreach (var item in first5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("SkipWhile(4)");
            var while4 = entiers.SkipWhile(e => e < 4);
            foreach (var item in while4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
