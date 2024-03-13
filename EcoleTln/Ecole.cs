using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int anneeCreation;
        private Dictionary<int ,Contact> contact  = new Dictionary<int,Contact>();

        public Ecole(string nom, int anneeCreation, Dictionary<int, Contact> contacts)
        {
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.Contacts = contacts;
        }

        public string AfficheTous()
        {
            string count = "";
            foreach(Contact contact in contact.Values)
            {
                count += contact.ToString();
                
            }
            return count;
        }
        /*public double AncienneteMoyenne()
        {
            
        }*/
        /*public bool EstEtudiant(Contact contact)
        {
            
        }*/

        public int NbContacts()
        {
            return contact.Count;
        }

        /*public double MoyenneEtudiantRegulier()
        {
            
        }*/
        
        public void AjouterContact(Contact contact)
        {
            if (!ExisteContact(contact))
            {
                this.contact.Add(contact.Matricule, contact);
            }
        }

        /*public int NbEtudiants()
        {
            
        }*/

        public bool ExisteContact(Contact contact)
        {
            return this.contact.ContainsKey(contact.Matricule);
        }

        
        public string Nom { get => nom; }
        public int AnneeCreation { get => anneeCreation; }
        internal Dictionary<int, Contact> Contacts { get => contact;  private set => contact = value; }
    }
}
