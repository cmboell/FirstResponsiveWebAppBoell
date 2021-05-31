using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppBoell.Models;

//in charge of flow of data between view and model
namespace FirstResponsiveWebAppBoell.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // displays blank URL to the user
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View(); //returns view
        }

        [HttpPost] //processes data submitted by user
        public IActionResult Index(DetermineAgeModel model)
        {
            if (ModelState.IsValid) //if input is valid
            {
                ViewBag.FV = model.AgeThisYear(); //displays result
            }
            else //if input is not valid
            {
                ViewBag.FV = 0; //displays if invalid input
            }
            return View(model); //returns/displays view with results and user input
        }

    }
}