namespace Application;


public class Commande
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public int Quantite { get; set; }
    public decimal Prix { get; set; }
    public DateTime DateCommande { get; set; }
}