using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Select
    {
        public void Methode()
        {
            int[] entiers = new int[5] { 1, 2, 3, 4, 5 };

            var entiersAuCarre
                = entiers.Select(e => e * e);

            foreach (var item in entiersAuCarre)
            {
                Console.WriteLine(item);
            }

            var jours 
                = entiers.Select(e => (DayOfWeek)e);

            foreach (var item in jours)
            {
                Console.WriteLine(item);
            }

            var dates = new DateTime[5]
            {
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(-1),
                DateTime.Today,
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
            };

            var numeroJours
                = dates.Select(d => d.Day);
            foreach (var item in numeroJours)
            {
                Console.WriteLine(item);
            }
        }
    }
}
