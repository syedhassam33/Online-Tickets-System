using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineTicketSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listMovies = _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Cinema.Name).ToList();
            return View(listMovies);
        }
    }
}
