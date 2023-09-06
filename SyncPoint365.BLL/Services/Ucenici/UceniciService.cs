using SyncPoint365.BLL.Models;
using SyncPoint365.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Ucenici
{
    public class UceniciService : IUceniciService
    {
        public List<Ucenik> GetUcenici(string query = null)
        {
            query = query?.ToLower();
            return Data.Ucenici.Where(u => query == null || u.BrojUcenika.ToLower().Contains(query) || u.Ime.ToLower().Contains(query)
          || u.Prezime.ToLower().Contains(query)).ToList();
        }

        public Ucenik GetByID(int id)
        {
            var ucenik = Data.Ucenici.Find(u => u.Id == id);
            return ucenik;
        }
        public void DodajUcenika(Ucenik ucenik)
        {
            throw new NotImplementedException();
        }

        public void UrediUcenika(int id, Ucenik ucenik)
        {
            var index = Data.Ucenici.FindIndex(u => u.Id == ucenik.Id);
            Data.Ucenici[index] = ucenik;
        }
        public void IzbrisiUcenika(int id)
        {
            Data.Ucenici.RemoveAll(u => u.Id == id);
        }
    }
}
