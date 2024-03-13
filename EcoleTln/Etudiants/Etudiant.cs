using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Etudiant : Contact
    {
        private string section;

        public Etudiant(int matricule, string nom, int anneeArrivee, string section) : base(matricule, nom, anneeArrivee)
        {
            this.section = section;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\n\tSection : {0}", this.Section);
        }

        public string Section { get => section; set => section = value; }
    }
}
