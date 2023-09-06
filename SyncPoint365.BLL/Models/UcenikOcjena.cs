using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPoint365.BLL.Models
{
    public class UcenikOcjena
    {
        public int Id { get; set; }
        public int UcenikId { get; set; }
        public string Predmet { get; set; }
        public int Ocjena { get; set; }
    }
}
