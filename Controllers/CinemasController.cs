using Microsoft.AspNetCore.Mvc;
using OnlineTicketSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listCinemas = _context.Cinemas.ToList();
            return View(listCinemas);
        }
    }
}
