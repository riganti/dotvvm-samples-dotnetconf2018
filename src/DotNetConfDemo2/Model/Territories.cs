using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace DotNetConfDemo2.Model
{
    public partial class Territories
    {
        public Territories()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
        }

        [Column("TerritoryId")]
        public string Id { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
        public virtual Region Region { get; set; }
    }
}
