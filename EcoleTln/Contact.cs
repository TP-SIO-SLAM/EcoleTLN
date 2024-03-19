using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    public class Contact
    {
        // on déclare des variables protected, donc elles ne seront pas accessibles dans les classes filles
        protected int matricule;
        protected string nom;
        protected int anneeArrivee;

        
        /// <summary>
        /// On déclare un constructeur publique qui prend 3 paramètres un entier matricule, une chaine de charactère nom
        /// et un entier anneeArrivee
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="nom"></param>
        /// <param name="anneeArrivee"></param>
        public Contact(int matricule, string nom, int anneeArrivee)
        {
            // on déclare que chaque variable que l'on a déclaré ci dessus correspond aux valeurs passé en paramètre
            // quand on appellera le constructeur et qu'on lui attribura ses paramètres 
            this.matricule = matricule;
            this.nom = nom;
            // Sauf pour celle la, ou l'on affecte la valeur du paramètre à la property AnneeArrivee
            this.AnneeArrivee = anneeArrivee;
        }

        /// <summary>
        /// On déclare la méthode ToString en publique qui doit retourner une chaine de charactère. Cette méthode est en override
        /// parce qu'elle existe déjà dans la classe Object, donc override sert à réecrire la méthode.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // On retourne le matricule, nom et l'année d'arrivée (Property) de notre objet Contact, le tout formaté en chaine de charactères
            return String.Format("\n\tMatricule : {0} \n\tNom : {1} \n\tAnnée : {2}", this.Matricule, this.Nom, this.AnneeArrivee);

        }

        public int Matricule { get => matricule; }
        public string Nom { get => nom; }

        public int AnneeArrivee { get => anneeArrivee; 
            set { 

                // On vérifie que la Date actuelle (que l'on récupère avec les properties de la classe DateTime)
                // est inférieure ou égale à la valeur que l'utilisateur veut insérer.
                if (value <= DateTime.Now.Year)
                {
                    anneeArrivee = value;
                }
                else
                {
                    // On déclenche une nouvelle exception si l'année d'arrivée est supérieure à l'année actuelle,
                    // pour être sur que la valeur soit cohérente
                    throw new Exception("L'année d'arrivée ne peut être supérieure à l'année courante");
                }
            }
        }
    }
}
