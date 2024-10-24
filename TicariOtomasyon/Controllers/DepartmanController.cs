using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Departmans.Where(x=>x.Durum==true).ToList();
            return View(values);
        }
        public IActionResult SilinenDepartmanlar()
        {
            var values = _context.Departmans.Where(x=>x.Durum==false).ToList();
            return View(values);
        }
        public IActionResult DepartmanYukle(int id)
        {
            var dep = _context.Departmans.Find(id);
            if(dep != null)
            {
                dep.Durum = true;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DepartmanEkle(Departman d)
        {
            _context.Departmans.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanSil(int id)
        {
            var dep = _context.Departmans.Find(id);
            if (dep != null)
            {
                dep.Durum = false;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
