using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse
{
    public class Ope_Generation
    {
        public void Methode()
        {
            var vide = Enumerable.Empty<int>();

            var unACinq = Enumerable.Range(1, 5);
            foreach (var item in unACinq)
            {
                Console.WriteLine(item);
            }

            var cinqTrue = Enumerable.Repeat(true, 5);
        }
    }
}
