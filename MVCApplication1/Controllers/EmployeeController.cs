using Microsoft.AspNetCore.Mvc;
using MVCApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContex;
        public EmployeeController(ApplicationDbContext dbContex)
        {
            this.dbContex = dbContex;
        }
        public IActionResult Index()
        {
            List<Employee>emp = dbContex.Employees.ToList();
            return View(emp);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                dbContex.Employees.Add(emp);
                dbContex.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(emp);
            }
           
        }
        public IActionResult Delete(int id)
        {
            var emp=dbContex.Employees.SingleOrDefault(emp=>emp.Id==id);
            if(emp!=null)
            {
                dbContex.Employees.Remove(emp);
                dbContex.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public IActionResult Edit(int id)
        {
            var emp = dbContex.Employees.SingleOrDefault(emp => emp.Id == id);
            return View(emp);

        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
           dbContex.Employees.Update(emp);
            dbContex.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
