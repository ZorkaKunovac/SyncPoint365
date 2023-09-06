using SyncPoint365.BLL.Models;
using SyncPoint365.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SyncPoint365.Models;
using SyncPoint365.BLL.Services.Ucenici;
using SyncPoint365.Web.ViewModels;

namespace BLLVjezba.Controllers
{
    public class UceniciController : Controller
    {
        private IUceniciService _UceniciService;
        public UceniciController(IUceniciService uceniciService) { 
            _UceniciService= uceniciService;
        }
        public IActionResult Index()
        {
            var vm = new UceniciIndexViewModel
            {
                Ucenici = _UceniciService.GetUcenici()
            };

             return View(vm);
        }
        [HttpPost]
        public IActionResult Index(UceniciIndexViewModel viewModel)
        {
            var vm = new UceniciIndexViewModel
            {
                Ucenici = _UceniciService.GetUcenici(viewModel.Query)
            };
            return View(vm);
        }

        public IActionResult Dodaj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dodaj(Ucenik noviucenik)
        {
            //public bool DOdajUcenika
            var ucenici = Data.GetUcenici();
            //if (ucenici.Any(u => u.BrojUcenika == noviucenik.BrojUcenika))
            //    return false;
            //else
            //{

            //}
            noviucenik.Id = Data.Ucenici.Count + 1;
            ucenici.Add(noviucenik);

            return RedirectToAction("Index");
        }

        public IActionResult Uredi(int id)
        {
            var ucenik = Data.Ucenici.Find(u => u.Id == id);

            return View(ucenik);
        }

        [HttpPost]
        public IActionResult Uredi(Ucenik editucenik)
        {
            var index = Data.Ucenici.FindIndex(c => c.Id == editucenik.Id);
            Data.Ucenici[index] = editucenik;

            return RedirectToAction("Index");
        }
        public IActionResult Obrisi(int id)
        {
            Data.Ucenici.RemoveAll(u => u.Id == id);

            return RedirectToAction("Index");
        }
    }
}
