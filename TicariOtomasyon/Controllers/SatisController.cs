using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.SatisHarekets.Include(u => u.Urun).Include(u => u.Cariler).Include(u => u.Personel).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult SatisYap()
        {
            ViewBag.personel = new SelectList(_context.Personels.Select(p => new
            {
                id = p.Id,
                FullName = p.PersonelAd + " " + p.PersonelSoyad
            }),
                                                    "id",
                                                    "FullName"
                                                );

            ViewBag.cari = new SelectList(_context.Carilers.Select(p => new
            {
                Id = p.CariId,
                FullName = p.CariAd + " " + p.CariSoyad
            }),
                                                    "Id",
                                                    "FullName");
            ViewBag.urun = new SelectList(_context.Uruns, "Id", "UrunAd");
            return View();
        }
        [HttpPost]
        public IActionResult SatisYap(SatisHareket s)
        {
            var cari = _context.Carilers.Find(s.Cariler.CariId);
            var personel = _context.Personels.Find(s.Personel.Id);
            var urun = _context.Uruns.Find(s.Urun.Id);
            s.Cariler = cari;
            s.Personel = personel;
            s.Urun = urun;
            s.Tarih = DateTime.Now;
            _context.SatisHarekets.Add(s);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
