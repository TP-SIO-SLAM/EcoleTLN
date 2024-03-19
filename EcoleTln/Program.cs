using Classes.ClassesEcole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // On déclare un objet de type Ecole que l'on appelle ecoleTLN et on affecte les valeurs écoleTLN en nom,
                // 1980 en année creation et on appelle la méthode CreerContacts pour créer un dictionnaire de contact
                Ecole ecoleTLN = new Ecole("écoleTLN", 1980, CreerContacts());

                // On appelle des méthodes qui se trouve dans la classe Ecole, et on écrit dans l'invite de commande
                Console.WriteLine("Parmi les " + ecoleTLN.NbContacts() + " personnes de l'EcoleTLN " + ecoleTLN.NbEtudiants() +
                    " sont des étudiants \nIls sont à l'école depuis en moyenne " + ecoleTLN.AncienneteMoyenne());

                Console.WriteLine("----  Affichage Tous ----");
                // On appelle la méthode AfficheTous qui se trouve dans la classe Ecole
                Console.WriteLine(ecoleTLN.AfficheTous());
                Console.WriteLine("---- Ajout d'un contact ----");
                Console.WriteLine("---- Ajout d'une collection de contacts ----");

                // On déclare un objet Contact qu'on appelle contact, qui se trouve dans la classe Contact,
                // on crée un nouvel objet contact et on affecte le matricule, nom, année arrivée
                Contact contact = new Contact(1789, "Montes Quieu", 2021);
                // On appelle la méthode AjouterContact de la classe Ecole, et on lui passe l'objet contact ci dessus en paramètre
                ecoleTLN.AjouterContact(contact);

                Console.WriteLine("---- Vérifications ----");
                // On appelle la méthode NbContacts de la classe Ecole
                Console.WriteLine("Nb contacts : {0}", ecoleTLN.NbContacts());

                // On appelle la méthode ExisteContact de la classe Ecole, et on lui passe l'objet contact ci dessus en paramètre
                ecoleTLN.ExisteContact(contact);

                Console.WriteLine(ecoleTLN.EstEtudiant(contact));

                Console.WriteLine("La moyenne des étudiants réguliers est : " + ecoleTLN.MoyenneEtudiantRegulier() + "\n");

                Console.WriteLine("Fin du programme...");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();

        }

        /// <summary>
        /// On décalre une méthode publique et statique qui doit renvoyer un Dictionnaire
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, Contact> CreerContacts()
        {
            // on déclare un Dictionnaire d'objets Contact avec une clé int. Et on affecte le nouveau Dictionnaire à contacts
            Dictionary<int, Contact> contacts = new Dictionary<int, Contact>();
            
            // On ajoute des Objets Contact avec tous leurs paramètres au dictionnaire contacts,
            // En précisant la classe auquel le Contact appartiendra (EtudiantRegulier ou EtudiantEchange
            // ou Enseignant ou Secretaire).
            contacts.Add(1200, new EtudiantRegulier(1200, "Gaston Peutimide", 2013, "SSC", 6));
            contacts.Add(1204, new EtudiantRegulier(1204, "Yvan Rattrapeur", 2011, "SSC", 2.5));
            contacts.Add(2324, new EtudiantRegulier(2324, "TOto rattrape", 2004, "SSC", 8));
            contacts.Add(1345, new EtudiantEchange(1345, "Bjorn borgue", 2012, "Informatique", "KTH"));
            contacts.Add(1114, new Enseignant(1114, "Mathieu Matheu", 1998, "LMEP", 10000, "Physique"));
            contacts.Add(1409, new Secretaire(1409, "Sophie Scribona", 2005, "LMT", 5000));
            
            // On retourne le dictionnaire de contacts après avoir ajouté tous les contacts.
            return contacts;
        }
    }
}
