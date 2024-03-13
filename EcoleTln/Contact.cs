using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        protected int anneeArrivee;

        

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }
        public override string ToString()
        {
            return String.Format("\n\tMatricule : {0} \n\tNom : {1} \n\tAnnée : {2}", this.Matricule, this.Nom, this.AnneeArrivee);

        }
        public int Matricule { get => matricule; }
        public string Nom { get => nom; }
        public int AnneeArrivee { get => anneeArrivee; 
            set { anneeArrivee = value; }
        }
    }
}
