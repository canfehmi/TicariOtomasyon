using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            if (!ModelState.IsValid)
            {
                return View("CariEkle");
            }
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
        public IActionResult CariGetir(int id)
        {
            var value = _context.Carilers.Find(id);
            return View("CariGetir", value);
        }
        public IActionResult CariGuncelle(Cariler c)
        {
            if (!ModelState.IsValid)
            {
                return View("CariGetir");
            }
            var value = _context.Carilers.Where(x=>x.CariId==c.CariId).FirstOrDefault();
            value.CariAd = c.CariAd;
            value.CariSoyad = c.CariSoyad;
            value.CariSehir = c.CariSehir;
            value.CariMail = c.CariMail;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriSatis(int id)
        {
            var values = _context.SatisHarekets.Where(x=> x.Cariler.CariId==id).Include(u=>u.Urun).Include(u=>u.Personel).ToList();
            var cari = _context.Carilers.Where(x => x.CariId == id).Select(u => u.CariAd + " " + u.CariSoyad).FirstOrDefault();
            ViewBag.cari = cari;
            return View(values);
        }
    }
}
