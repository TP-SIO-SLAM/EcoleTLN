using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Enseignant : Personnel
    {
        // on déclare une chaîne de charactères section privée
        private string section;

        /// <summary>
        /// On déclare un constructeur publique. La clause : base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Personnel en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="nomLaboratoire"></param>
        /// <param name="salaire"></param>
        /// <param name="section"></param>
        public Enseignant(int matricule, string nom, int anneeArrivee, string nomLaboratoire, int salaire, string section) : base(matricule,nom,anneeArrivee,nomLaboratoire,salaire)
        {
            // on affecte la valeur du paramètre section à notre attribut section, et pas aux autres, parce qu'on leur
            // affecte déjà dans la classe mère (Personnel)
            this.section = section;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne la Section (Property) de notre objet Enseignant, le tout formaté en chaine de charactères
            return String.Format("\nEnseignant : {0} \n\tSection : {1}\n", base.ToString(), this.Section);
        }

        public string Section { get => section; set => section = value; }
    }
}
