using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantEchange : Etudiant
    {
        private string universiteOrigine;

        public EtudiantEchange(int matricule, string nom, int anneeArrivee, string section, string universiteOrigine) : base(matricule, nom, anneeArrivee,section)
        {
            this.universiteOrigine = universiteOrigine;
        }
        public override string ToString()
        {
            return String.Format("\nEtudiant Echangé : {0} \n\tUniversité d'origine : {1}\n", base.ToString(), this.UniversiteOrigine);
        }
        public string UniversiteOrigine { get => universiteOrigine; }
    }
}
