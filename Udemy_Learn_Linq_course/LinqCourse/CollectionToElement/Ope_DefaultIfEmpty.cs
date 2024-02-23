using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_DefaultIfEmpty
    {
        public void Methode()
        {
            int[] entiers = new[] { 1, 2, 3, 4, 5 };

            var entiersSuperieursACinq = entiers.Where(i => i > 5);

            Console.WriteLine(entiersSuperieursACinq.DefaultIfEmpty().First());
        }
    }
}
