using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Where
    {
        public void Methode()
        {
            int[] entiers = new int[5] { 1, 2, 3, 4, 5 };

            //opérateur where classique
            var entiersSuperieurA3 =
                entiers.Where(el => el > 3);

            foreach (var item in entiersSuperieurA3)
            {
                Console.WriteLine(item);
            }

            // opérateur where avec index
            var entiersImpairs =
                entiers.Where((_, index) => index % 2 != 0);

            foreach (var item in entiersImpairs)
            {
                Console.WriteLine(item);
            }

            // avec des objets "complexes"
            var dates = new DateTime[5]
            {
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(-1),
                DateTime.Today,
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
            };

            var datefutures =
                dates.Where(date => date.Date > DateTime.Today);

            foreach (var item in datefutures)
            {
                Console.WriteLine(item);
            }
        }

        public bool SuperieurATrois(int entier)
        {
            return entier > 3;
        }
    }
}
