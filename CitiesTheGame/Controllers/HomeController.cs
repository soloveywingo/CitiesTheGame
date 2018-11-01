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
        [HttpPost]
        public ActionResult Index(CitiesViewModel citiesViewModel)
        {
            if (ModelState.IsValid)
            {
                Cities.citiesThatWere.Add(citiesViewModel.PersonName.ToArray(), citiesViewModel.CityName.ToUpper());
                Cities.StartLetter = citiesViewModel.CityName.ToString()[citiesViewModel.CityName.ToString().Length -1];
            }
            return View(citiesViewModel);

        }
        [HttpGet]
        public ActionResult Index()
        {
            CitiesViewModel citiesViewModel = new CitiesViewModel
            {
                collectedCities = Cities.citiesThatWere
            };
            return View(citiesViewModel);
        }
    }
}