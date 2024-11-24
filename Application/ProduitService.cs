namespace Application;

public class ProduitService
{
    private List<Produit> produits = new List<Produit>();
    private Random random = new Random();

    public List<Produit> GetAll()
    {
        for (int i = 1; i <= 10; i++)
        {
            produits.Add(new Produit
            {
                Id = i,
                Nom = $"Produit {i}",
                Quantite = random.Next(1, 100),
                Prix = (decimal)(random.NextDouble() * 100),
                Description = $"Description du produit {i}",
                Image = $"https://picsum.photos/200/300?random={i}"
            });
        }
        return produits;
    }

    public Produit GetById(int id)
    {
        return produits.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Produit produit)
    {
        produit.Id = produits.Count > 0 ? produits.Max(p => p.Id) + 1 : 1;
        produits.Add(produit);
    }

    public void Update(int id, Produit produit)
    {
        var produitToUpdate = produits.FirstOrDefault(p => p.Id == id);
        if (produitToUpdate == null)
        {
            return;
        }
        produitToUpdate.Nom = produit.Nom;
        produitToUpdate.Quantite = produit.Quantite;
        produitToUpdate.Prix = produit.Prix;
        produitToUpdate.Description = produit.Description;
        produitToUpdate.Image = produit.Image;
    }

    public void Delete(int id)
    {
        var produitToDelete = produits.FirstOrDefault(p => p.Id == id);
        if (produitToDelete == null)
        {
            return;
        }
        produits.Remove(produitToDelete);
    }
}