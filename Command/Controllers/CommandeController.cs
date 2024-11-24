using Application;
using Microsoft.AspNetCore.Mvc;

namespace Command.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommandeController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        var commandeService = new CommandeService();
        return Ok(commandeService.GetAll());
    }
    
    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var commandeService = new CommandeService();
        return Ok(commandeService.GetById(id));
    }
    
    [HttpPost]
    public ActionResult Post(Commande commande)
    {
        var commandeService = new CommandeService();
        commandeService.Add(commande);
        return Ok("Created");
    }
    
    [HttpPut("{id}")]
    public ActionResult Put(int id, Commande commande)
    {
        var commandeService = new CommandeService();
        commandeService.Update(id, commande);
        return Ok("Update");
    }
    
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var commandeService = new CommandeService();
        commandeService.Delete(id);
        return Ok("Delete");
    }
}