using Microsoft.AspNetCore.Mvc;
using OnlineTicketSystem.Data;
using OnlineTicketSystem.Data.Services;
using OnlineTicketSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _services;
        public ActorsController(IActorsServices services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAllActors();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("FullName, ActPictureURL, AboutAct")]Actors actors)
        {
            if (!ModelState.IsValid)
            {
                return View(actors);
            }

            _services.AddActor(actors);
            return RedirectToAction(nameof(Index));
        }

        public  IActionResult Details(int id)
        {
            var data = _services.GetActorById(id);
            if (data == null) return View("Not properl described.");
            return View(data);
        }
    }
}
