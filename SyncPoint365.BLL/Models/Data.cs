using SyncPoint365.BLL.Models;

namespace LernaWebApp3.Models
{
    public class Data
    {
        public static List<Country> Countries = new List<Country> {
            new Country {
                Id = 1,
                Name = "Bosnia and Herzegovina"
                },
        new Country
        {
            Id = 2,
            Name = "Croatia"
        },
        new Country
        {
            Id = 3,
            Name = "Serbia"
        }
        };

        public static List<Country> GetCountries()
        {

            return Countries;
        }
    }
}
