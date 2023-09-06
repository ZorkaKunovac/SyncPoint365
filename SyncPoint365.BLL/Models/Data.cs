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

        public static List<UcenikOcjena> Ocjene = new List<UcenikOcjena> {
            new UcenikOcjena {
                Id = 1,
                UcenikId=1,
                Predmet="Programiranje 1",
                Ocjena=7
                },
             new UcenikOcjena {
                Id = 2,
                UcenikId=1,
                Predmet="Programiranje 2",
                Ocjena=9
                },
               new UcenikOcjena {
                Id = 3,
                UcenikId=1,
                Predmet="Programiranje 3",
                Ocjena=6
                },
        };

        public static List<UcenikOcjena> GetOcjene()
        {
            return Ocjene;
        }
    }
}
