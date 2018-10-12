namespace Assignment1012.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public Customer()
        {
            Sales = new HashSet<Sale>();
        }
    }
}