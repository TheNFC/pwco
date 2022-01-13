using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwco.Models;

namespace pwco.Controllers
{
    public class EmployeesController : Controller
    {
       public IActionResult GetEmployees()
        {
            List<EmployeesVM> employee = null;

            try
            {
                using (pwcodbContext context = new pwcodbContext())
                {
                    employee = context.Employees.Select(x => new EmployeesVM(x)).ToList();
                }
            }
            catch(Exception ex)
            {
                employee = new List<EmployeesVM>();
            }

            return View("GetEmployees",employee);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new EmployeesVM());
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeesVM employees)
        {
            using (pwcodbContext context = new pwcodbContext())
            {
                var newEmployee = new Employees()
                {
                    Id = employees.Id,
                    Name = employees.Name,
                    Surname = employees.Surname,
                    Phone = employees.Phone,
                    Email = employees.Email
                };

                context.Employees.Add(newEmployee);
                context.SaveChanges();
            }
            return RedirectToAction("GetEmployees");
        }
        [HttpGet]
        public IActionResult EditEmployee(int Id)
        {
            List<EmployeesVM> employees = null;
            using (pwcodbContext context = new pwcodbContext())
            {
                employees = context.Employees.Select(x => new EmployeesVM(x)).ToList();
            }
            var tmp = employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(tmp);
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeesVM employee)
        {
            using (pwcodbContext context = new pwcodbContext())
            {
                var newEmployee = new Employees()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Surname = employee.Surname,
                    Phone = employee.Phone,
                    Email = employee.Email
                };

                context.Employees.Update(newEmployee);
                context.SaveChanges();

            }
            return RedirectToAction("GetEmployees");
        }
        [HttpGet]
        public IActionResult DeleteEmployee(int Id)
        {
            List<EmployeesVM> employees = null;
            using (pwcodbContext context = new pwcodbContext())
            {
                employees = context.Employees.Select(x => new EmployeesVM(x)).ToList();
            }
            var tmp = employees.Where(x => x.Id == Id).FirstOrDefault();
            return View(tmp);
        }
        [HttpPost]
        public IActionResult DeleteEmployee(EmployeesVM employee)
        {
            using (pwcodbContext context = new pwcodbContext())
            {
                var newEmployee = new Employees()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Surname = employee.Surname,
                    Phone = employee.Phone,
                    Email = employee.Email
                };

                context.Employees.Remove(newEmployee);
                context.SaveChanges();

            }
            return RedirectToAction("GetEmployees");
        }
    }
}
