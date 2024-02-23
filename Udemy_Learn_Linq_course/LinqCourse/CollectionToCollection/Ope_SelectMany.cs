using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class SacElement
    {
        public List<int> Entiers { get; set; }

        public List<DateTime> Dates { get; set; }
    }
    public class Ope_SelectMany
    {
        public void Methode()
        {
            SacElement[] sacs = new SacElement[3]
            {
                new SacElement{
                    Entiers = new List<int> { 1, 2, 3, 4, 5} ,
                    Dates = new List<DateTime>
                    {
                        DateTime.Today.AddDays(-5),
                        DateTime.Today.AddDays(-4),
                        DateTime.Today.AddDays(-3),
                        DateTime.Today.AddDays(-2),
                        DateTime.Today.AddDays(-1)
                    }
                },
                new SacElement{
                    Entiers = new List<int> { 6, 7 ,8 },
                    Dates = new List<DateTime>
                    {
                        DateTime.Today
                    }
                },
                new SacElement{
                    Entiers = new List<int> { 9, 10, 11, 12, 13, 14, 15} ,
                    Dates = new List<DateTime>
                    {
                        DateTime.Today.AddDays(1),
                        DateTime.Today.AddDays(2),
                        DateTime.Today.AddDays(3),
                        DateTime.Today.AddDays(4),
                        DateTime.Today.AddDays(5)
                    }
                }
            };

            var tousLesEntiers =
                sacs.SelectMany(sac => sac.Entiers);

            foreach (var item in tousLesEntiers)
            {
                Console.WriteLine(item);
            }

            var tousLesNumerosDeJours
                = sacs.SelectMany(sac => sac.Dates, (sac, date) =>  date.Day);

            foreach (var item in tousLesNumerosDeJours)
            {
                Console.WriteLine(item);
            }
        }
    }
}
