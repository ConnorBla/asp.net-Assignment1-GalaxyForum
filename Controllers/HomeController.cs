using System.Diagnostics;
using GalaxyForum.Data;
using GalaxyForum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GalaxyForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly GalaxyForumContext _context;

        public HomeController(GalaxyForumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var discussions = await _context.Discussions
                .Include(d => d.Comments)
                .ToListAsync();
            if (discussions == null || discussions.Count() == 0)
            {
                // Handle the case where discussions are null or empty
                return View(new List<Discussion>());
            }
            return View(discussions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

