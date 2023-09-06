using SyncPoint365.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Ocjene
{
    public interface IOcjeneService
    {
        List<UcenikOcjena> GetOcjeneByUcenikId(int ucenikId);
        float GetProsjekOcjenaByUcenikId(int ucenikId);
        void IzbrisiOcjenu(int id);
    }
}
