using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesLinq
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public List<Personne> Enfants { get; set; }
        public int IdAdresse { get; set; }

        public Personne? Clone()
        {
            return MemberwiseClone() as Personne;
        }
    }
}
