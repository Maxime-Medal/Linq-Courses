using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Concat
    {
        public void Methode()
        {
            var entiers1 = new int[] { 1, 2, 3, 4, 5 };
            var entiers2 = new int[] { 6, 7, 8, 9, 10 };

            var chaines = new string[] { "a", "b", "c" };

            var entiers3 = entiers1.Concat(entiers2);

            foreach (var item in entiers3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
