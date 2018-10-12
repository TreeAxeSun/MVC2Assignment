namespace Assignment1012.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public Product()
        {
            Sales = new HashSet<Sale>();
        }

    }

}