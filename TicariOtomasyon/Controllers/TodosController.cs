using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class TodosController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var deger1 = _context.Carilers.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = _context.Uruns.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = _context.Kategoris.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = (from x in _context.Carilers select x.CariSehir).Distinct().Count().ToString();
            ViewBag.d4 = deger4;

            var values = _context.Todos.ToList();
            return View(values);
        }
    }
}
