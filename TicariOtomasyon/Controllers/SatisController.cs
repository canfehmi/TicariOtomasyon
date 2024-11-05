using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
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
        [HttpGet]
        public IActionResult SatisGetir(int id)
        {
            var value = _context.SatisHarekets.Include(u => u.Cariler).Include(u => u.Personel).Include(u => u.Urun).FirstOrDefault(u => u.Id == id);
            if (value != null)
            {
                ViewBag.personel = new SelectList(_context.Personels.Select(p => new
                {
                    Id = p.Id,
                    FullName = p.PersonelAd + " " + p.PersonelSoyad
                }),
                "Id", "FullName"
                );
                ViewBag.urun = new SelectList(_context.Uruns, "Id", "UrunAd");
                ViewBag.cari = new SelectList(_context.Carilers.Select(p => new
                {
                    Id = p.CariId,
                    FullName = p.CariAd + " " + p.CariSoyad
                }),
                    "Id", "FullName");
            }
            return View("SatisGetir", value);
        }
        [HttpPost]
        public IActionResult SatisGetir(SatisHareket s)
        {
            if(!ModelState.IsValid)
            {
                var value = _context.SatisHarekets.Include(u => u.Cariler).Include(u => u.Personel).Include(u => u.Urun).FirstOrDefault(u => u.Id == s.Id);
                if (value == null)
                {
                    return NotFound();
                }
                if(value != null && s.Urun.Id != value.Urun.Id)
                {
                    value.Urun = _context.Uruns.Find(s.Urun.Id);
                }
                if (value != null && s.Personel.Id != value.Personel.Id)
                {
                    value.Personel = _context.Personels.Find(s.Personel.Id);
                }
                if (value != null && s.Cariler.CariId != value.Cariler.CariId)
                {
                    value.Cariler = _context.Carilers.Find(s.Cariler.CariId);
                }
                value.Adet = s.Adet;
                value.ToplamTutar = s.ToplamTutar;
                value.Fiyat = s.Fiyat;
                value.Tarih = DateTime.Now;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(s);
        }
        public IActionResult SatisDetay(int id)
        {
            var values = _context.SatisHarekets.Where(u=>u.Id==id).Include(u=>u.Cariler).Include(u=>u.Personel).Include(u=>u.Urun).ToList();
            return View(values);
        }
    }
}
