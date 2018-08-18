using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using DotNetConfDemo1.Services;

namespace DotNetConfDemo1.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly CountriesService countriesService;

        public AddressDTO BillingAddress { get; set; } = new AddressDTO()
        {
            CountryId = 45
        };

        public List<CountryDTO> Countries { get; set; }

        public List<StateDTO> States { get; set; }


        public DefaultViewModel(CountriesService countriesService)
        {
            this.countriesService = countriesService;
        }

        public override Task PreRender()
        {
            // load countries on first page load
            if (!Context.IsPostBack)
            {
                Countries = countriesService.GetCountries();
                States = new List<StateDTO>();
            }

            return base.PreRender();
        }

        public void SubmitOrder()
        {
            // TODO: paste the magic here
        }

        public void OnCountryChanged()
        {
            States = countriesService.GetStatesByCountry(BillingAddress.CountryId);
        }
    }
}
