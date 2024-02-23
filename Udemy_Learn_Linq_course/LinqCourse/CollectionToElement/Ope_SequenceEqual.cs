using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_SequenceEqual
    {
        public void Methode()
        {
            IEnumerable<int> entiers = new[] { 1, 2, 3, 4, 5 };
            var entiers2 = new[] { 1, 2, 3, 4, 5 };

            var egal = entiers.SequenceEqual(entiers2);

            Console.WriteLine(egal);

            var entiersTab = entiers.ToArray();
            var egal2 = entiersTab[1..^1].SequenceEqual(new[] { 2, 3, 4 });
            Console.WriteLine(egal2);
        }
    }
}
