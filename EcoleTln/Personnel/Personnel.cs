using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Personnel : Contact

    {
        private string nomLaboratoire;
        private double salaire;

        public Personnel(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\n\tLaboratoire : {0} \n\tSalaire : {1}", this.NomLaboratoire, this.Salaire);
        }
        public string NomLaboratoire { get => nomLaboratoire; }
        public double Salaire { get => salaire;}
    }
}
