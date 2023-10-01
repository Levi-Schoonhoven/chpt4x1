
using chpt4x1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//using MovieList.Models;'
using Microsoft.EntityFrameworkCore;

namespace chpt4x1.Controllers
{
    public class HomeController : Controller
    {
       private MovieContext context { get; set; }

        public HomeController (MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }

       
    }
}