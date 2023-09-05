using SyncPoint365.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Countries
{
    public interface ICountriesService
    {
        List<Country> GetCountries(string search = null);
        Country GetByID(int id);
        void Add(Country country);
        void Edit(Country country);
        void Delete(int id);
    }
}
