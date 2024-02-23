using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_MinMax
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };

            var plusPetit = entiers.Min();
            var plusGrand = entiers.Max();

            Console.WriteLine(plusPetit);
            Console.WriteLine(plusGrand);

            var plusPetitDivisible = entiers.Min(i => i % 4);
            var plusGrandDivisible = entiers.Max(i => i % 4);
            Console.WriteLine(plusPetitDivisible);
            Console.WriteLine(plusGrandDivisible);
        }
    }
}
