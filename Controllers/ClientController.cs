using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionClient.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            var client = new Client()
            {
                Id = 1,
                Nom = "anasri",
                Prenom = "anas",
                Ville = "Casa"
            };

            return View(client);
        }

        public IActionResult pro()
        {
            return View();
        }

    }
}
