using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Personnel : Contact
    {
        // on déclare les attributs nomLaboratoire et salaire
        private string nomLaboratoire;
        private double salaire;

        /// <summary>
        /// On déclare un constructeur publique. La clause : base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Contact en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="nomLaboratoire"></param>
        /// <param name="salaire"></param>
        public Personnel(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee)
        {
            // on affecte la valeur des paramètres nomLaboratoire et salaire à nos attributs, et pas aux autres, parce qu'on leur
            // affecte déjà dans la classe mère (Contact)
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne le NomLaboratoire et Salaire (Property) de notre objet Enseignant,
            // le tout formaté en chaine de charactères
            return String.Format("{0}\n\tLaboratoire : {1} \n\tSalaire : {2}", base.ToString(), this.NomLaboratoire, this.Salaire);
        }

        public string NomLaboratoire { get => nomLaboratoire; }
        public double Salaire { get => salaire;}
    }
}
