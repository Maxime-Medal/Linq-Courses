using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_ElementAt
    {
        public void Methode()
        {
            IEnumerable<int> entiers = new[] { 1, 2, 3, 4, 5, 6 };

            var premier = entiers.ElementAt(0);
            var dernier = entiers.ElementAt(^1);

            var existePas = entiers.ElementAtOrDefault(10);
            Console.WriteLine(existePas);
        }
    }
}
