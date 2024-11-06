using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Uruns.ToList();
            return View(values);
        }
    }
}
