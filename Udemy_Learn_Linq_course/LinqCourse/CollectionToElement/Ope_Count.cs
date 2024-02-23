using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Count
    {
        public void Methode()
        {
            IEnumerable<int> entiers = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(entiers.Count());
            Console.WriteLine(entiers.Count(i => i > 3));

            Console.WriteLine(entiers.LongCount());
            Console.WriteLine(entiers.LongCount(i => i > 3));
        }
    }
}
