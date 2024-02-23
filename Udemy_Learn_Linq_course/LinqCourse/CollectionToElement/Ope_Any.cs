using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Any
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };
            var vide = Array.Empty<int>();

            var auMoinsUnElement = entiers.Any();

            Console.WriteLine(auMoinsUnElement);

            var auMoinsUnElement2 = vide.Any();

            Console.WriteLine(auMoinsUnElement2);

            var auMoinsUnElementSuperieurATrois = entiers.Any(i => i > 3);
            // attention : moins performant
            var auMoinsUnElementSuperieurATrois2 = entiers.Where(i => i > 3).Count() > 0;
            Console.WriteLine(auMoinsUnElementSuperieurATrois);
        }
    }
}
