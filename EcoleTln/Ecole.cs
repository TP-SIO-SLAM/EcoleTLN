using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        // on déclare une chaine de charactères que l'on appelle nom
        private string nom;
        // on déclare un entier que l'on nomme anneeCreation
        private int anneeCreation;
        // on déclare un dictionnaire d'objets contacts et on lui affecte une nouvelle instance du dictionnaire
        private Dictionary<int, Contact> contacts  = new Dictionary<int,Contact>();


        /// <summary>
        /// On déclare un constructeur publique Ecole avec 3 paramètres, une chaîne de charactères nom, un entier année de création
        /// de l'école, et un Dictionnaire d'objets Contact
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="anneeCreation"></param>
        /// <param name="contacts"></param>
        public Ecole(string nom, int anneeCreation, Dictionary<int, Contact> contacts)
        {
            // on déclare que chaque variable que l'on a déclaré ci dessus correspond aux valeurs passé en paramètre
            // quand on appellera le constructeur et qu'on lui attribura ses paramètres 
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.contacts = contacts;
        }

        /// <summary>
        /// on déclare une méthode publique qui doit retouner une chaine de charactère
        /// </summary>
        /// <returns></returns>
        public string AfficheTous()
        {
            // on déclare une chaine de charactère message, et on lui affecte une chaine de charactères vide
            string message = "";
            // on fait une boucle qui passera sur chaque objet Contact présent dans la colonne valeur de notre dictionnaire de contacts
            foreach(Contact contact in contacts.Values)
            {
                // On affecte la valeur du contact convertie en chaine de charactère. Cette valeur est rajouté à la chaine
                // de charactères message déjà présente
                message += contact.ToString();
            }

            // on retourne la chaine de charactère message en sortant de la boucle
            return message;
        }

        /// <summary>
        /// on déclare une méthode publique qui doit retourner un nombre à virgule
        /// </summary>
        /// <returns></returns>
        public double AncienneteMoyenne()
        {
            // on déclare un nombre à virgule somme, et on lui affecte le chiffre 0
            double somme = 0;
            // on fait une boucle qui passera sur chaque objet Contact présent dans la colonne valeur de notre dictionnaire de contacts
            foreach (Contact contact in contacts.Values)
            {
                // On récupère l'année actuelle, et on la soustrait à l'année d'arrivée du contact, puis on l'additionne à
                // la somme existante, pour ensuite l'affecter à la variable somme.
                somme += DateTime.Now.Year - contact.AnneeArrivee;
            }

            // on divise la somme de l'ancienneté de tous nos contacts par notre nombre de contact pour obtenir la moyenne
            // d'ancinneté de nos contacts, puis on retourne cette valeur.
            return somme / contacts.Count;
        }


        /// <summary>
        /// on déclare une méthode publique qui doit retourner un boolean et qui prend en paramètre un objet de type Contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public bool EstEtudiant(Contact contact)
        {
            // on retourne true si l'objet Contact est une instance de la classe Etudiant
            return contact is Etudiant;

            /*if (contact is Etudiant)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        /// <summary>
        /// on déclare une méthode publique qui doit retourner un entier
        /// </summary>
        /// <returns></returns>
        public int NbContacts()
        {
            // on compte le nombre de valeurs présente dans le dictionnaire contacts avec la property Count, puis on retourne cette valeur
            return this.contacts.Count;
        }

        /// <summary>
        /// on déclare une méthode publique qui doit retourner un nombre à virgule
        /// </summary>
        /// <returns></returns>
        public double MoyenneEtudiantRegulier()
        {
            // on déclare un nombre à virgule somme, et on lui affecte la valeur 0
            double somme = 0;
            // on déclare un entier nbEtudiantsReg, et on lui affecte la valeur 0
            int nbEtudiantsReg = 0;
            // on fait une boucle qui passera sur chaque objet Contact présent dans la colonne valeur de notre dictionnaire de contacts
            foreach (Contact contact in Contacts.Values)
            {
                // si notre objet contact est une instance de la classe EtudiantRegulier on rentre dans la condition
                if (contact is EtudiantRegulier etudiantReg)
                {
                    // on récupère la NoteMoyenne de l'objet etudiantReg via sa property NoteMoyenne, et on l'aditionne
                    // à la somme de la variable somme 
                    somme += etudiantReg.NoteMoyenne;
                    // on rajoute un entier 1 à la variable nbEtudiantsReg
                    nbEtudiantsReg ++;
                }

                /*if (contact is EtudiantRegulier)
                {
                    somme += ((EtudiantRegulier)contact).NoteMoyenne;
                    nbEtudiantsReg++;
                }*/
            }

            // on retourne la somme de toutes les moyennes des étudiants réguliers additioné, divisé par le nombre d'étudiants
            // regulier pour obtenir la moyenne des notes des étudiants réguliers
            return somme / nbEtudiantsReg;
        }

        /// <summary>
        ///  on déclare une méthode publique void qui prend en paramètre l'objet contact
        /// </summary>
        /// <param name="contact"></param>
        public void AjouterContact(Contact contact)
        {
            // on vérifie si le contact existe en appelant la méthode ExisteContact et en lui passant notre paramètre contact
            // en paramètre, et on rentre dans cette condition si la méthode ExisteContact nous renvoie false
            if (!ExisteContact(contact))
            {
                // on récupère notre dictionnaire de contacts et on lui ajoute un nouveau contact. Le premier paramètre que l'on
                // rentre contact.Matricule correspond à la clé TKey, et le deuxième paramètre, contact correspond à la valeur que
                // l'on veut rentrer dans le dictionnaire
                this.contacts.Add(contact.Matricule, contact);
            }
        }


        /// <summary>
        /// On surcharge la méthode AjouterContact avec un dictionnaire de contacts
        /// </summary>
        /// <param name="contacts"></param>
        public void AjouterContact(Dictionary<int, Contact> contacts)
        {
            // on fait une boucle qui passera sur chaque objet Contact présent dans la colonne valeur de notre dictionnaire de contacts
            foreach (Contact contact in contacts.Values)
            {
                // pour chaque contact présent dans notre dictionnaire, on rajoutera un contact dans notre dictionnaire de contacts
                this.AjouterContact(contact);
            }
        }

        /// <summary>
        /// on déclare une méthode NbEtudiants qui doit renvoyer un entier
        /// </summary>
        /// <returns></returns>
        public int NbEtudiants()
        {
            // on déclare un entier nbEtudiants et on initialise sa valeur à 0
            int nbEtudiants = 0;
            // on fait une boucle qui passera sur chaque objet Contact présent dans la colonne valeur de notre dictionnaire de contacts
            foreach (Contact contact in Contacts.Values)
            {
                // chaque fois qu'un contact sera une instance de la classe Etudiant on rentrera dans cette condition
                if (contact is Etudiant)
                {
                    // On rajoute un entier 1 à notre entier nbEtudiants
                    nbEtudiants ++;
                }
            }

            // on retourne la valeur nbEtudiants en sortant de la boucle foreach
            return nbEtudiants;
        }

        /// <summary>
        /// On déclare une méthode ExisteContact qui prend en paramètre un objet Contact et qui doit renvoyer un boolean
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public bool ExisteContact(Contact contact)
        {
            // on retourne true si la Tkey du contact mis en paramètre correspond à une Tkey présente dans le dictionnaire
            return this.contacts.ContainsKey(contact.Matricule);
        }

        
        public string Nom { get => nom; }
        public int AnneeCreation { get => anneeCreation; }
        // On instancie la property de notre dictionnaire contacts, avec un getter et un setter
        // Cette property est en internal parce que l'on restreint sa portée à la classe.
        internal Dictionary<int, Contact> Contacts { get => contacts;  private set => contacts = value; }
    }
}
