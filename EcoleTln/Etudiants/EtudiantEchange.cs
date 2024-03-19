using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantEchange : Etudiant
    {
        // on déclare une chaine de charactère universiteOrigine
        private string universiteOrigine;

        /// <summary>
        /// On déclare un constructeur publique. La clause :base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Etudiant en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="section"></param>
        /// <param name="universiteOrigine"></param>
        public EtudiantEchange(int matricule, string nom, int anneeArrivee, string section, string universiteOrigine) : base(matricule, nom, anneeArrivee,section)
        {
            // on affecte la valeur du paramètre universiteOrigine à notre attribut universiteOrigine,
            // et pas aux autres, parce qu'on leur affecte déjà dans la classe mère (Etudiant)
            this.universiteOrigine = universiteOrigine;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne l'UniversiteOrigine (property) de notre Objet EtudiantEchange, et les paramètres présent dans base,
            // le tout formaté en chaine de charactères.
            return String.Format("\nEtudiant Echangé : {0} \n\tUniversité d'origine : {1}\n", base.ToString(), this.UniversiteOrigine);
        }

        public string UniversiteOrigine { get => universiteOrigine; }
    }
}
