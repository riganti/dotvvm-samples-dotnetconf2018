using DotNetConfDemo1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetConfDemo1.Services
{
    public class CountriesService
    {
        private readonly AppDbContext dbContext;

        public CountriesService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<CountryDTO> GetCountries()
        {
            return dbContext.Countries
                .OrderBy(c => c.Name)
                .Select(c => new CountryDTO()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }

        public List<StateDTO> GetStatesByCountry(int countryId)
        {
            return dbContext.States
                .Where(s => s.CountryId == countryId)
                .OrderBy(s => s.Name)
                .Select(s => new StateDTO()
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToList();
        }
    }
}
