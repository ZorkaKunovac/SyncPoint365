using Microsoft.AspNetCore.Mvc;
using SyncPoint365.BLL.Models;
using SyncPoint365.BLL.Services.Countries;
using SyncPoint365.Web.ViewModels;

namespace SyncPoint365.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountriesService _countriesService;
        public CountriesController(ICountriesService countriesService) { 
            _countriesService = countriesService;
        }
        public IActionResult Index()
        {
            var vm = new CountriesIndexViewModel
            {
                Countries = _countriesService.GetCountries()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(CountriesIndexViewModel viewModel)
        {           
            var vm = new CountriesIndexViewModel
            {
                Countries = _countriesService.GetCountries(viewModel.Search)
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Country country)
        {
             _countriesService.Add(country);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var country = _countriesService.GetByID(id);

            return View(country);
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            _countriesService.Edit(country);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
             _countriesService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
