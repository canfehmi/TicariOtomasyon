using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Entities;
namespace TicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Uruns.Where(x=>x.Durum==true).Include(u => u.Kategori).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UrunEkle()
        {
            ViewBag.Kategoriler = new SelectList(_context.Kategoris, "KategoriId", "KategoriAd");
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun u)
        {
            var kategori = _context.Kategoris.Find(u.Kategori.KategoriId);
            if (kategori != null)
            {
                u.Kategori = kategori;
                u.Durum = true;
                _context.Uruns.Add(u);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult UrunSil(int id)
        {
            var deger = _context.Uruns.Find(id);
            deger.Durum = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UrunGetir(int id)
        {
            var urun = _context.Uruns.Include(u=> u.Kategori).FirstOrDefault(u => u.Id == id);
            if (urun == null)
            {
                return NotFound();
            }
            ViewBag.Kategoriler = new SelectList(_context.Kategoris, "KategoriId", "KategoriAd", urun.Kategori.KategoriAd);
            return View(urun);
        }
        [HttpPost]
        public IActionResult UrunGetir(Urun urun)
        {
            if(!ModelState.IsValid)
            {
                var u = _context.Uruns.Include(x => x.Kategori).FirstOrDefault(y => y.Id == urun.Id);
                if (u == null)
                {
                    return NotFound();
                }
                u.UrunAd = urun.UrunAd;
                u.AlisFiyat = urun.AlisFiyat;
                u.SatisFiyat = urun.SatisFiyat;
                u.Stok = urun.Stok;
                u.Durum = urun.Durum;
                u.Marka = urun.Marka;
                u.UrunGorsel = urun.UrunGorsel;
                if (urun.Kategori != null && urun.Kategori.KategoriId != u.Kategori.KategoriId)
                {
                    u.Kategori = _context.Kategoris.Find(urun.Kategori.KategoriId);
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Kategoriler = new SelectList(_context.Kategoris, "KategoriId", "KategoriAd", urun.Kategori.KategoriId);
            return View(urun);
        }
    }
}
