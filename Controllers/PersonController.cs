using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using core2test.Models;
using System.Linq;

namespace core2test.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonContext _context;

        public PersonController(PersonContext context)
        {
            _context = context;

            if (_context.People.Count() == 0)
            {
                _context.People.Add(new Person { Name = "Jonny" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return _context.People.ToList();
        }

        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetById(long id)
        {
            var item = _context.People.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}