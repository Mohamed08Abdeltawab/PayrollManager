// Represents job positions or titles held by employees
using System;
using System.Collections.Generic;

namespace PayrollManager.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property for EF Core
        public ICollection<Employee> Employees { get; set; }
    }
}