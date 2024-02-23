using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_All
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };

            var tousLesEntierssuperieursAZero = entiers.All(i => i > 0);
            Console.WriteLine(tousLesEntierssuperieursAZero);

            var tousLesEntierssuperieursATrois = entiers.All(i => i > 3);
            Console.WriteLine(tousLesEntierssuperieursATrois);
        }
    }
}
