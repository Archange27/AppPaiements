using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        
        public CarteCredit(double montant, string description, int numeroCarte)
            : base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Paiement par Carte de Crédit : {Montant}$ - {Description} - Numéro de carte : {NumeroCarte}");
        }
    }

}
