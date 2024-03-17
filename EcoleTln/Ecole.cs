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
        private string nom;
        private int anneeCreation;
        private Dictionary<int, Contact> contacts  = new Dictionary<int,Contact>();

        public Ecole(string nom, int anneeCreation, Dictionary<int, Contact> contacts)
        {
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.Contacts = contacts;
        }

        public string AfficheTous()
        {
            string count = "";
            foreach(Contact contact in contacts.Values)
            {
                count += contact.ToString();
                
            }
            return count;
        }

        public double AncienneteMoyenne()
        {
            int moyenne = 0;
            foreach (Contact contact in contacts.Values)
            {
                moyenne += contact.AnneeArrivee;
            }
            return moyenne / contacts.Count;
        }

        public bool EstEtudiant(Contact contact)
        {
            if (contact is Etudiant) return true;
            else return false;
        }

        public int NbContacts()
        {
            return contacts.Count;
        }

        public double MoyenneEtudiantRegulier()
        {
            double moyenne = 0;
            int nbEtudiantsReg = 0;
            foreach (Contact contact in Contacts.Values)
            {
                if (contact is EtudiantRegulier EtudiantReg)
                {
                    moyenne += EtudiantReg.NoteMoyenne;
                    nbEtudiantsReg ++;
                }
            }
            return moyenne / nbEtudiantsReg;
        }

        public void AjouterContact(Contact contact)
        {
            if (!ExisteContact(contact))
            {
                this.contacts.Add(contact.Matricule, contact);
            }
        }

        public int NbEtudiants()
        {
            return 0;
        }

        public bool ExisteContact(Contact contact)
        {
            return this.contacts.ContainsKey(contact.Matricule);
        }

        
        public string Nom { get => nom; }
        public int AnneeCreation { get => anneeCreation; }
        internal Dictionary<int, Contact> Contacts { get => contacts;  private set => contacts = value; }
    }
}
