using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise.CollectionToCollection
{
    internal class ope_Where
    {
        public void Methode()
        {
            int[] entiers = new int[5] { 1, 2, 3, 4, 5 };

            // opérateur classique
            var entierSupA3 =
                entiers.Where(NumIsOver3);

            Console.WriteLine("Entier Supérieur à 3");
            foreach (int i in entierSupA3)
            {
                Console.WriteLine(i);
            }

            // opérateur avec index
            var oddInt = entiers.Where((_, index) => index % 2 != 0);

            Console.WriteLine("Entier pair");
            foreach (int i in oddInt)
            {
                Console.WriteLine(i);
            }

            // opérateur avec objets "complexes"
            var dates = new DateTime[5]
            {
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(-1),
                DateTime.Today,
                DateTime.Today.AddDays(+1),
                DateTime.Today.AddDays(+2),
            };

            var futurDates = dates.Where(date => date.Date > DateTime.Today);

            foreach (var date in futurDates)
            {
                Console.WriteLine(date);
            }
        }
        public bool NumIsOver3(int value)
        {
            return value > 3;
        }
    }
}
