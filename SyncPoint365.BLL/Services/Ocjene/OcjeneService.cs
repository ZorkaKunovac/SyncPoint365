using SyncPoint365.BLL.Models;
using SyncPoint365.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Services.Ocjene
{
    public class OcjeneService : IOcjeneService
    {
        public List<UcenikOcjena> GetOcjeneByUcenikId(int ucenikId)
        { 
           var ocjena = Data.Ocjene.Where(o => o.UcenikId == ucenikId).ToList();
            return ocjena;
        }

        public float GetProsjekOcjenaByUcenikId(int ucenikId)
        {
            var ocjene = Data.Ocjene.Where(o => o.UcenikId == ucenikId).ToList();

            throw new NotImplementedException();
        }

        public void IzbrisiOcjenu(int id)
        {
            Data.Ocjene.RemoveAll(o => o.Id == id);
        }
    }
}
