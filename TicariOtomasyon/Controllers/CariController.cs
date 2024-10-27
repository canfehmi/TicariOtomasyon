using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Carilers.Where(u=>u.Durum==true).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CariEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CariEkle(Cariler c)
        {
            c.Durum = true;
            _context.Carilers.Add(c);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CariSil(int id)
        {
            var c = _context.Carilers.Find(id);
            if (c != null)
            {
                c.Durum = false;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult SilinenCariler()
        {
            var values = _context.Carilers.Where(u=>u.Durum==false).ToList();
            return View(values);
        }
        public IActionResult CariYukle(int id)
        {
            var c = _context.Carilers.Find(id);
            if(c != null)
            {
                c.Durum = true;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
