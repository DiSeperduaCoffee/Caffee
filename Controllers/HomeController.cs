using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DiSeperduaCoffe.Models;
using Microsoft.AspNetCore.Identity;
using DiSeperduaCoffee.Models;
using DiSeperduaCoffee.Data;
using Microsoft.AspNetCore.Authorization;

namespace DiSeperduaCoffe.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DiSeperduaCoffeeDbContext _context;
        private UserManager<Pengguna> _userManager;

        public HomeController(ILogger<HomeController> logger, DiSeperduaCoffeeDbContext context, UserManager<Pengguna> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId); 
            return View();
        }

        public IActionResult Privacy()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId); 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var userId = _userManager.GetUserId(User);
            var user = _context.Users.Find(userId); 
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
