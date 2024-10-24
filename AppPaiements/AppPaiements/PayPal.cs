using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class PayPal : Paiement
    {
        public string Courriel {  get; set; }
        public PayPal(double montant, string description, string courriel)
        : base(montant, description)
        {
            Courriel = courriel;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Paiement par Paypal : {Montant}$ - {Description} - Courriel : {Courriel}");
        }
    }
}
