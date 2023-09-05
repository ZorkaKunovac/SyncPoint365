using LernaWebApp3.Models;
using SyncPoint365.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Countries
{
    public class CountriesService : ICountriesService
    {       
        public List<Country> GetCountries(string search=null)
        {

            return Data.Countries.Where(c => search == null || c.Name.ToLower().Contains(search)).ToList();
        } 


        public Country GetByID(int id)
        {
            var country = Data.Countries.Find(s => s.Id == id);
            return country;
        }

        public void Add(Country country)
        {
            country.Id = Data.Countries.Count + 1;
            Data.Countries.Add(country);
        }

        public void Edit(Country country)
        {
            var index = Data.Countries.FindIndex(c => c.Id == country.Id);
            Data.Countries[index] = country;

        }
        public void Delete(int id)
        {
            Data.Countries.RemoveAll(d => d.Id == id);

        }
    }
}
