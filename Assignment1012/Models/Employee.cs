namespace Assignment1012.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        public int SaleId { get; set; }

        [InverseProperty("Employee")]
        public virtual ICollection<Sale> Sales { get; set; }

        public Employee()
        {
            Sales = new HashSet<Sale>();
        }
    }
}