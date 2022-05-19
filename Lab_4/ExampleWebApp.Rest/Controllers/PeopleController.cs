using Microsoft.AspNetCore.Mvc;
namespace ExampleWebApp.Rest.Database;
using ExampleWebApp.Rest.Database.Entities;
using ExampleWebApp.Rest.Database.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly PeopleDb db;

    public PeopleController(PeopleDb db)
    {
        this.db = db;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var people = await db.People.ToListAsync();
        return Ok(people);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePerson request)
    {
        if(!request.Validate())
        {
            throw new Exception("Incorrect model");
        }

        var personEntity = new PersonEntity(request.FirstName, request.LastName, request.PhoneNumber);
        db.People.Add(personEntity);
        await db.SaveChangesAsync();

        return Ok();
    }
}

