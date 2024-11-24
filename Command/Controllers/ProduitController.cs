using Application;
using Microsoft.AspNetCore.Mvc;

namespace Command.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProduitController : Controller
{
    ProduitService produitService = new ProduitService();
    [HttpGet]
    public ActionResult Index()
    {
        return Ok(produitService.GetAll());
    }
    
    [HttpGet("{id}", Name = "GetProduit")]
    public ActionResult Get(int id)
    {
        return Ok(produitService.GetById(id));
    }
    
    [HttpPost]
    public ActionResult Post([FromBody] Produit produit)
    {
        produitService.Add(produit);
        return CreatedAtRoute("GetProduit", new { id = produit.Id }, produit);
    }
    
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Produit produit)
    {
        produitService.Update(id, produit);
        return Ok(produit);
    }
    
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        produitService.Delete(id);
        return Ok("Deleted");
    }
}