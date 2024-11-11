using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = _context.Uruns.Where(u=>u.Id == 1).ToList();
            cs.Deger2 = _context.Detays.Where(u=>u.DetayId == 1).ToList();
            return View(cs);
        }
    }
}
