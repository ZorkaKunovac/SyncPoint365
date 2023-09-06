using SyncPoint365.BLL.Models;

namespace SyncPoint365.Models
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

        public static List<Ucenik> Ucenici = new List<Ucenik> {
            new Ucenik {
                Id = 1,
               BrojUcenika= "1",
               Ime="Zorka",
               Prezime="Kunovac"
                },
        new Ucenik
        {
            Id = 2,
           BrojUcenika="2",
           Ime="Belmin",
           Prezime="Sehic"
        },
        new Ucenik { Id = 3, BrojUcenika = "3",
        Ime="Adnan", Prezime= "Jusic"}
        };

        public static List<Ucenik> GetUcenici()
        {

            return Ucenici;
        }
    }
}
