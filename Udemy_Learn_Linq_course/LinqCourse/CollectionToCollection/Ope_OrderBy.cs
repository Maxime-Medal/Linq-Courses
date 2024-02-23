using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Personne //: IComparable<Personne>
    {
        public string Prenom { get; set; }
        public int Age { get; set; }

        /*public int CompareTo(Personne? other)
        {
            return Prenom.CompareTo(other?.Prenom);
        }*/
    }

    public class PersonneComparer : IComparer<Personne>
    {
        public int Compare(Personne? x, Personne? y)
        {
            if (x == null && y == null) return 0;
            if (y == null) return 1;
            if (x == null) return -1;
            return x.Prenom.CompareTo(y.Prenom);
        }
    }

    public class Ope_OrderBy
    {
        public void Methode()
        {
            int[] entiers = new int[8] { 1, 2, 3, 4, 5, 1, 2, 7 };

            var entiersTries =
                entiers.OrderBy(e => e);

            var entiersTries2 = entiers.Order();

            foreach (var item in entiersTries)
            {
                Console.WriteLine(item);
            }

            var entiersTriesDescendant
                = entiers.OrderByDescending(e => e);
            var entiersTriesDescendant2
                = entiers.OrderDescending();

            foreach (var item in entiersTriesDescendant)
            {
                Console.WriteLine(item);
            }

            var dates = new DateTime[5]
            {
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(2),
                DateTime.Today,
                DateTime.Today.AddDays(-1),
                DateTime.Today.AddDays(1),
            };

            var dateOrdonnees = dates.OrderBy(d => d.Day);
            foreach (var item in dateOrdonnees)
            {
                Console.WriteLine(item);
            }

            var personnes = new Personne[5]
            {
                new Personne{ Prenom = "Franck", Age = 20},
                new Personne{ Prenom = "Franck", Age = 35},
                new Personne{ Prenom = "Jean", Age = 55 },
                new Personne{ Prenom = "Albert", Age = 28},
                new Personne{ Prenom = "Albert", Age = 78},
            };
            //var personnesTriesAlphabet = personnes.OrderBy(p => p, new PersonneComparer());
            var personnesTriesAlphabet = personnes.Order(new PersonneComparer());
            foreach (var item in personnesTriesAlphabet)
            {
                Console.WriteLine($"{item.Prenom} {item.Age} ans");
            }

            var personnesParNomPuisAgeDescendant
                = personnes.OrderBy(p => p, new PersonneComparer())
                .ThenByDescending(p => p.Age);

            foreach (var item in personnesParNomPuisAgeDescendant)
            {
                Console.WriteLine($"{item.Prenom} {item.Age} ans");
            }
        }
    }
}
