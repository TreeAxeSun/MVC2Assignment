namespace Assignment1012.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date{ get; set; }

        public virtual Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; }

        public virtual StoreLocation StoreLocation { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public Sale()
        {
            Products = new HashSet<Product>();
        }
    }
}