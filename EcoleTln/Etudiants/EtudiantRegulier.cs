using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantRegulier : Etudiant
    {
        // on déclare un nombre à virgule, noteMoyenne
        private double noteMoyenne;

        /// <summary>
        /// On déclare un constructeur publique. La clause :base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Etudiant en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="section"></param>
        /// <param name="noteMoyenne"></param>
        public EtudiantRegulier(int matricule, string nom, int anneeArrivee,string section, double noteMoyenne) : base(matricule, nom, anneeArrivee, section)
        {
            // on affecte la valeur du paramètre noteMoyenne à notre attribut noteMoyenne,
            // et pas aux autres, parce qu'on leur affecte déjà dans la classe mère (Etudiant)
            this.noteMoyenne = noteMoyenne;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne les paramètres présent dans la base, et la NoteMoyenne (property) de notre Objet Etudiant Regulier,
            // Le tout formaté en chaine de charactères.
            return String.Format("\nEtudiant Régulier : {0} \n\tMoyenne : {1}\n", base.ToString(), this.NoteMoyenne);
        }

        public double NoteMoyenne { get => noteMoyenne; }
    }
}
