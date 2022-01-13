using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwco.Models;

namespace pwco.Models
{
    public class EmployeesVM
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public EmployeesVM()
        {

        }

        public EmployeesVM(Employees model)
        {
            Id = model.Id;
            Name = model.Name;
            Surname = model.Surname;
            Phone = model.Phone;
            Email = model.Email;
        }
    }
}
