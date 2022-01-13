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
    }
}
