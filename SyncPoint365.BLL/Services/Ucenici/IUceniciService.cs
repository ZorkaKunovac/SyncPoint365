using SyncPoint365.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Ucenici
{
    public interface IUceniciService
    {
        List<Ucenik> GetUcenici(string query = null);
        Ucenik GetByID(int id);
        void DodajUcenika(Ucenik ucenik);
        void UrediUcenika(int id, Ucenik ucenik);
        void IzbrisiUcenika(int id);

    }
}
