using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using core2test.Models;
using System.Linq;

namespace core2test.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly PersonContext _context;

        public TodoController(PersonContext context)
        {
            _context = context;

            if (_context.People.Count() == 0)
            {
                _context.People.Add(new Person { Name = "Jonny" });
                _context.SaveChanges();
            }
        }       
    }
}