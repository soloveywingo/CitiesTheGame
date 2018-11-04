using CitiesTheGame.Models;
using CitiesTheGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CitiesTheGame.Controllers
{
    public class HomeController : Controller
    {
        // GET: Cities
      

        [HttpGet]
        public ActionResult Index()
        {
            CitiesViewModel citiesViewModel = new CitiesViewModel
            {
                CollectedCities = Cities.CitiesThatWereUsed
            };
            return View(citiesViewModel);
        }
        [HttpPost]
        public ActionResult Index(CitiesViewModel citiesViewModel)
        {
            if (ModelState.IsValid)
            {
                Cities.CitiesThatWereUsed.Add(citiesViewModel.PersonName.ToArray(),
                    citiesViewModel.CityName.ToUpper());
                Cities.StartLetter = citiesViewModel.CityName.Last();

                return RedirectToAction("Index");
            }
            return View(citiesViewModel);
        }
    }
}