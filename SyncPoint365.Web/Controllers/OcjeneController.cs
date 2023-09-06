using Microsoft.AspNetCore.Mvc;
using SyncPoint365.BLL.Services.Ocjene;
using SyncPoint365.BLL.Services.Ucenici;
using SyncPoint365.ViewModels;
using SyncPoint365.Web.ViewModels;

namespace SyncPoint365.Web.Controllers
{
    public class OcjeneController : Controller
    {
        private IOcjeneService _ocjeneService;
        public OcjeneController(IOcjeneService ocjeneService)
        {
            _ocjeneService= ocjeneService;
        }
        public IActionResult Index(int ucenikid)
        {
            var vm = new UcenikOcjenaIndexViewModel
            {
                ocjene = _ocjeneService.GetOcjeneByUcenikId(ucenikid)
            };
            return View(vm);
        }

        public IActionResult Obrisi(int id, int ucenikId)
        {
            _ocjeneService.IzbrisiOcjenu(id);

            return RedirectToAction("Index", new { ucenikid = ucenikId });
        }
    }
}
