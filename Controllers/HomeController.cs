﻿using ManejoTareas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace ManejoTareas.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> stringLocalizer;

        public HomeController(ILogger<HomeController> logger, 
                              IStringLocalizer<HomeController> stringLocalizer) {
            _logger = logger;
            this.stringLocalizer = stringLocalizer;
        }

        public IActionResult Index() {
            ViewBag.Saludo = stringLocalizer["Buenos días"];

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}