namespace Application;

public class CommandeService
{
    private List<Commande> commandes = new List<Commande>();
    private Random random = new Random();

    public CommandeService()
    {
        // Générer des données aléatoires initiales
        for (int i = 1; i <= 10; i++)
        {
            commandes.Add(new Commande
            {
                Id = i,
                Nom = $"Commande {i}",
                Quantite = random.Next(1, 100),
                Prix = (decimal)(random.NextDouble() * 100),
                DateCommande = DateTime.Now.AddDays(-random.Next(1, 30))
            });
        }
    }

    public IEnumerable<Commande> GetAll()
    {
        return commandes;
    }

    public Commande GetById(int id)
    {
        return commandes.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Commande newCommande)
    {
        newCommande.Id = commandes.Count > 0 ? commandes.Max(c => c.Id) + 1 : 1;
        commandes.Add(newCommande);
    }

    public bool Update(int id, Commande updatedCommande)
    {
        var commande = commandes.FirstOrDefault(c => c.Id == id);
        if (commande == null)
        {
            return false;
        }
        commande.Nom = updatedCommande.Nom;
        commande.Quantite = updatedCommande.Quantite;
        commande.Prix = updatedCommande.Prix;
        commande.DateCommande = updatedCommande.DateCommande;
        return true;
    }

    public bool Delete(int id)
    {
        var commande = commandes.FirstOrDefault(c => c.Id == id);
        if (commande == null)
        {
            return false;
        }
        commandes.Remove(commande);
        return true;
    }
}