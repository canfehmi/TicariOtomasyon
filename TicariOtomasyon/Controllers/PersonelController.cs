using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Personels.Include(u => u.Departman).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PersonelEkle()
        {
            ViewBag.depts = new SelectList(_context.Departmans, "Id", "DepartmanAdi");
            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel p)
        {
            var dep = _context.Departmans.Find(p.Departman.Id);
            if (dep != null)
            {
                p.Departman = dep;
                _context.Personels.Add(p);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult PersonelSatis(int id)
        {
            var values = _context.SatisHarekets.Where(u => u.Personel.Id == id).Include(u=>u.Urun).Include(u=>u.Cariler).ToList();
            ViewBag.personel = _context.Personels.Where(u=>u.Id==id).Select(u=> u.PersonelAd + " " + u.PersonelSoyad).FirstOrDefault();
            return View(values);
        }
        public IActionResult PersonelGetir(int id)
        {
            var per = _context.Personels.FirstOrDefault(u => u.Id == id);
            ViewBag.depts = new SelectList(_context.Departmans, "Id", "DepartmanAdi");
            return View(per);
        }
        public IActionResult PersonelGuncelle(Personel p)
        {
            var pers = _context.Personels.FirstOrDefault(u =>u.Id == p.Id);
            var dep = _context.Departmans.Find(p.Departman.Id);
            if (dep != null && pers != null)
            {
                pers.Departman = dep;
                pers.PersonelAd = p.PersonelAd;
                pers.PersonelSoyad = p.PersonelSoyad;
                pers.PersonelGorsel = p.PersonelGorsel;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
