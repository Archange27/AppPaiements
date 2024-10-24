using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }  
        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom de l'utilisateur : {Nom}");
        }
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
            Console.WriteLine($"Paiement ajouté pour {Nom} : {paiement.Description} - {paiement.Montant}$");
        }
        public void AfficherPaiements()
        {
            Console.WriteLine($"Liste des paiements de {Nom} :");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}


