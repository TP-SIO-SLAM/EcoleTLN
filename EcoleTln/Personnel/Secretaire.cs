using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Secretaire : Personnel
    {
        /// <summary>
        /// On déclare un constructeur publique. La clause :base sert à récupérer les paramètres existant dans la classe mère,
        /// qui est la classe Personnel en l'occurrence.
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        /// <param name="nomLaboratoire"></param>
        /// <param name="salaire"></param>
        public Secretaire(int matricule, string nom, int anneeArrivee, string nomLaboratoire, int salaire) : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire) { }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne les attributs présent dans base, formaté en chaine de charactères
            return String.Format("\nSecrétaire : {0} ", base.ToString());
        }
    }
}
