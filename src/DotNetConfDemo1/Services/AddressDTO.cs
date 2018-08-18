using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetConfDemo1.Services
{
    public class AddressDTO
    {
        [Required]
        public string Name { get; set; }

        public bool IsCompany { get; set; }

        public string TaxNumber { get; set; }

        [Required]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        [Required]
        public string City { get; set; }

        public int? StateId { get; set; }

        public int CountryId { get; set; }

        public string ZIP { get; set; }

    }
}
