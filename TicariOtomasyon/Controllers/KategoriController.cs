using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Kategoris.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori k)
        {
            _context.Kategoris.Add(k);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KategoriSil(int id)
        {
            var t = _context.Kategoris.Find(id);
            _context.Remove(t);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KategoriGetir(int id)
        {
            var kategori = _context.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        public IActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = _context.Kategoris.Find(k.KategoriId);
            ktgr.KategoriAd = k.KategoriAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
