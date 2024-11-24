using Application;
using Microsoft.AspNetCore.Mvc;

namespace Command.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommandeController : Controller
{
    private CommandeService commandeService = new CommandeService();
        
    [HttpGet]
    public ActionResult Index()
    {
        return Ok(commandeService.GetAll());
    }
    
    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        return Ok(commandeService.GetById(id));
    }
    
    [HttpPost]
    public ActionResult Post([FromBody] Commande commande)
    {
        commandeService.Add(commande);
        return Ok("Created");
    }
    
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Commande commande)
    {
        commandeService.Update(id, commande);
        return Ok("Update");
    }
    
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        commandeService.Delete(id);
        return Ok("Delete");
    }
}