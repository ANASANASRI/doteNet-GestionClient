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
                Id = 1000,
                Nom = "anasri",
                Prenom = "anas",
                Ville = "Casa"
            };

            return View(client);
        }



        public IActionResult form()
        {
            return View();
        }


        public IActionResult liste()
        {
            List<Client> listeclient = new List<Client>
            {
                new Client
                {
                Id = 1000,
                Nom = "anasri",
                Prenom = "anas",
                Ville = "Casa"
                },
                new Client
                {
                Id = 2000,
                Nom = "ytut",
                Prenom = "aajkhnas",
                Ville = "Casa"
                },
                new Client
                {
                Id = 3000,
                Nom = "jshjsh",
                Prenom = "smnkl",
                Ville = "agjag"
                }
            };
            ViewBag.clients = listeclient;
            return View(listeclient);
        }



        [HttpPost]
        public IActionResult Save(Client client)
        {
            return View(client);
        }



        public IActionResult pro()
        {
            return View();
        }

    }
}
