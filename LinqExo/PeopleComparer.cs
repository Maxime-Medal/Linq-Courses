using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{

        public class PeopleComparer : IComparer<People>
        {
            public int Compare(People? x, People? y)
            {
                if (x == null && y == null) return 0;
                if (y == null) return 1;
                if (x == null) return -1;
                return x.FirstName.CompareTo(y.FirstName);
            }
        }
}
