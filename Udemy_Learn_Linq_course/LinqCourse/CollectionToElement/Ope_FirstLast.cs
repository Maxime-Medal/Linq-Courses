using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_FirstLast
    {
        public void Methode()
        {
            IEnumerable<int> entiers = new[] { 1, 2, 3, 4, 5, 6 };

            var premier = entiers.First();
            var dernier = entiers.Last();
            Console.WriteLine(premier);
            Console.WriteLine(dernier);

            var premierPlusGrandQueTrois = entiers.First(i => i > 3);
            Console.WriteLine(premierPlusGrandQueTrois);

            var dernierPlusGrandQueTrois = entiers.Last(i => i > 3);
            Console.WriteLine(dernierPlusGrandQueTrois);

            var entiers2 = Array.Empty<int>();

            var premierOuDefaut = entiers.FirstOrDefault(i => i > 8, 42);
            //var premierOuDefaut2 = entiers.First(i => i > 8);
            Console.WriteLine(premierOuDefaut);
        }
    }
}
