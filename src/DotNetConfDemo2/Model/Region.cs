using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace DotNetConfDemo2.Model
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territories>();
        }

        [Column("RegionId")]
        public int Id { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }
    }
}
