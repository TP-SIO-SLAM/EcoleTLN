﻿using Classes.ClassesEcole;
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
                Ecole ecoleTLN = new Ecole("écoleTLN", 1980, CreerContacts());
                Console.WriteLine("---- Ajout d'une collection de contact ----");
                Console.WriteLine("----  Affichage Tous ----");
                Console.WriteLine(ecoleTLN.AfficheTous());
                Console.WriteLine("---- Ajout d'un contact ----");
                Contact contact = new Contact(1789, "Montes Quieu", 2021);
                ecoleTLN.AjouterContact(contact);
                Console.WriteLine("---- Vérifications ----");
                Console.WriteLine("Nb contact : {0}", ecoleTLN.NbContacts());
                List<int> matric = new List<int> { 1200, 9999, 1789, 2222 };


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        public static Dictionary<int, Contact> CreerContacts()
        {
            Dictionary<int, Contact> contact = new Dictionary<int, Contact>();
            
            contact.Add(1200, new EtudiantRegulier(1200, "Gaston Peutimide", 2013, "SSC", 6));
            contact.Add(1204, new EtudiantRegulier(1204, "Yvan Rattrapeur", 2011, "SSC", 2.5));
            contact.Add(1345, new EtudiantEchange(1345, "Bjorn borgue", 2012, "Informatique", "KTH"));
            contact.Add(1114, new Enseignant(1114, "Mathieu Matheu", 1998, "LMEP", 10000, "Physique"));
            contact.Add(1409, new Secretaire(1409, "Sophie Scribona", 2005, "LMT", 5000));
            
            return contact;
        }
    }
}
