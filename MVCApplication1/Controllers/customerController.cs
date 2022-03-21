using Microsoft.AspNetCore.Mvc;
using MVCApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApplication1.Controllers
{
    public class customerController : Controller
    {
        private ApplicationDbContext dbContext;
        public customerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public IActionResult Index()
        {
            List<Locations> locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            List<Customer> customers = dbContext.Customers.Where(e => e.Locations.Id == id).ToList();
            return View(customers);
        }
    }
}
