using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Skip
    {
        public void Methode()
        {
            int[] entiers = new int[8] { 1, 2, 3, 4, 5, 1, 2, 7 };

            var cinqDerniersEntiers
                = entiers.Skip(2);

            Console.WriteLine("Skip (2)");
            foreach (var item in cinqDerniersEntiers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("SkipLast (2)");
            var cinqPremiersEntiers
                = entiers.SkipLast(2);

            foreach (var item in cinqPremiersEntiers)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("SkipWhile (2)");

            var entiersAPartirDeQuatre
                = entiers.SkipWhile(e => e < 4);

            foreach (var item in entiersAPartirDeQuatre)
            {
                Console.WriteLine(item);
            }

        }
    }
}
