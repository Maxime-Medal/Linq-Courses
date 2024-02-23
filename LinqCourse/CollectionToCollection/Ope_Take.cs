using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Take
    {
        public void Methode()
        {
            int[] entiers = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Two first");
            var first2 = entiers.Take(2);

            foreach (var item in first2)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("range");
            var range = entiers.Take(1..3);
            //var otherRange = entiers.Take(new Range(new Index(1), new Index(3)));
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("last 3");
                var last2 = entiers.TakeLast(3);

            foreach (var item in last2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("take while");
            var first3 = entiers.TakeWhile(e => e <= 3);
            foreach (var item in first3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
