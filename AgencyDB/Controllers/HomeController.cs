using AgencyDB.Data;
using AgencyDB.Models;
using AgencyDB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AgencyDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var banner = _context.Banners.FirstOrDefault();
            var service = _context.Services.ToList();
            var about = _context.Abouts.ToList();
            var portfolio = _context.Portfolios.Include(cat=>cat.Category).ToList();
            var team=_context.Teams.Include(x=>x.TeamNetworks).ThenInclude(y=>y.SocialNetwork).ToList();
            HomeVM vm = new()
            {
                Banner = banner,
                Services=service,
                Abouts=about,
                Portfolios=portfolio,
                Teams=team,
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Index");
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