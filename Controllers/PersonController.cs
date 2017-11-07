using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using core2test.Models;
using System.Linq;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace core2test.Controllers
{
    public class PersonController : JsonApiController<Person>
    {
        // private readonly IJsonApiContext _context;

        public PersonController(
            IJsonApiContext jsonApiContext,
            IResourceService<Person> resourceService,
            ILoggerFactory loggerFactory)
        : base(jsonApiContext, resourceService, loggerFactory)
        {
            // _context = jsonApiContext;

            // if (_context.People.Count() == 0)
            // {
            //     _context.People.Add(new Person { Name = "Jonny" });
            //     _context.SaveChanges();
            // }
        }

        // [HttpGet]
        // public IEnumerable<Person> GetAll()
        // {
        //     return _context.People.ToList();
        // }

        // [HttpGet("{id}", Name = "GetPerson")]
        // public IActionResult GetById(long id)
        // {
        //     var item = _context.People.FirstOrDefault(t => t.Id == id);
        //     if (item == null)
        //     {
        //         return NotFound();
        //     }
        //     return new ObjectResult(item);
        // }

        // [HttpPost]
        // public IActionResult Create([FromBody] Person item)
        // {
        //     if (item == null)
        //     {
        //         return BadRequest();
        //     }

        //     _context.People.Add(item);
        //     _context.SaveChanges();

        //     return CreatedAtRoute("GetPerson", new { id = item.Id }, item);
        // }

        // [HttpPut("{id}")]
        // public IActionResult Update(long id, [FromBody] Person item)
        // {
        //     if (item == null || item.Id != id)
        //     {
        //         return BadRequest();
        //     }

        //     var person = _context.People.FirstOrDefault(t => t.Id == id);
        //     if (person == null)
        //     {
        //         return NotFound();
        //     }

        //     person.IsHappy = item.IsHappy;
        //     person.Name = item.Name;

        //     _context.People.Update(person);
        //     _context.SaveChanges();
        //     return new NoContentResult();
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Delete(long id)
        // {
        //     var person = _context.People.FirstOrDefault(t => t.Id == id);
        //     if (person == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.People.Remove(person);
        //     _context.SaveChanges();
        //     return new NoContentResult();
        // }
    }
}