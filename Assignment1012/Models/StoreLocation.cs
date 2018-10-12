namespace Assignment1012.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class StoreLocation 
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public StoreLocation()
        {
            Sales = new HashSet<Sale>();
        }

    }
}