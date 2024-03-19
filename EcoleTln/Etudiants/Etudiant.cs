using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Etudiant : Contact
    {
        // on déclare une chaine de charactères section
        private string section;

        /// <summary>
        /// On déclare un constructeur publique. La clause :base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Contact en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="section"></param>
        public Etudiant(int matricule, string nom, int anneeArrivee, string section) : base(matricule, nom, anneeArrivee)
        {
            // on affecte la valeur du paramètre section à notre attribut section, et pas aux autres, parce qu'on leur
            // affecte déjà dans la classe mère (Contact)
            this.section = section;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne la Section (property) de notre Objet Etudiant, et les paramètres présent dans base,
            // le tout formaté en chaine de charactères.
            return String.Format("{0}\n\tSection : {1}", base.ToString(), this.Section);
        }

        public string Section { get => section; set => section = value; }
    }
}
