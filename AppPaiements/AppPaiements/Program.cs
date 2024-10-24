using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        Utilisateur utilisateur = new Utilisateur("Younes Boukouchi");
        CarteCredit paiementCarte = new CarteCredit(150, "Commande Uber Eats", 1123456789);
        PayPal paiementPaypal = new PayPal(200, "NetFlix", "Younes@gmail.com");

        utilisateur.AjouterPaiement(paiementCarte);
        utilisateur.AjouterPaiement(paiementPaypal);

        utilisateur.AfficherInfos();
        utilisateur.AfficherPaiements();

        Console.ReadLine();
    }
}