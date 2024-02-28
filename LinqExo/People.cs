﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<People> Children { get; set; }
        public int AddressId { get; set; }

        public People? Clone()
        {
            return MemberwiseClone() as People;
        }

        //public int CompareTo(People other)
        //{
        //    People newP = other as People;
        //    return Age.CompareTo(newP.Age);
        //}
    }
}
