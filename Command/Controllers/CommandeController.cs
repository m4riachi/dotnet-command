using Microsoft.AspNetCore.Mvc;

namespace Command.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommandeController : Controller
{
    [HttpGet]
    public string Index()
    {
        return "All";
    }
    
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "get by id";
    }
    
    [HttpPost]
    public string Post()
    {
        return "Create";
    }
    
    [HttpPut("{id}")]
    public string Put(int id)
    {
        return "Update";
    }
    
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Delete";
    }
}