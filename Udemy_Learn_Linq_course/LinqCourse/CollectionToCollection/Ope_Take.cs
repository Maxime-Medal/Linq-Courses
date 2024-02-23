using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Take
    {
        public void Methode()
        {
            int[] entiers = new int[7] { 1, 2, 3, 4, 5, 1, 2 };

            var deuxPremiersEntiers =
                entiers.Take(2);

            Console.WriteLine("Take (2)");
            foreach (var item in deuxPremiersEntiers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Take (1..3)");
            var sousEnsembleEntiers =
                entiers.Take(1..3);
                //entiers.Take(new Range(new Index(1), new Index(3)));

            foreach (var item in sousEnsembleEntiers)
            {
                Console.WriteLine(item);
            }

            var deuxDerniersEntiers
                = entiers.TakeLast(2);

            Console.WriteLine("TakeLast (2)");
            foreach (var item in deuxDerniersEntiers)
            {
                Console.WriteLine(item);
            }

            var troisPremiersEntiers
                = entiers.TakeWhile(e => e <= 3);

            Console.WriteLine("TakeWhile ( <= 3)");
            foreach (var item in troisPremiersEntiers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
