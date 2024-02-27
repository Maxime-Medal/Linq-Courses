using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Single
    {
        public void Methode()
        {
            int[] entiers = new[] { 1, 2, 3, 4, 5 };
            int[] entier2 = new[] { 1 };

            var entier = entiers.Where(i => i > 4).Single(); // souvent utiliser après un where pour vérifier la récupération d'un seul et unique élément
            Console.WriteLine(entier);

            var entierSingleOrDefault = entiers.SingleOrDefault(i => i > 5);
            Console.WriteLine(entierSingleOrDefault);
        }
    }
}
