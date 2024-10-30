using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult KaliciSil(int id)
        {
            var imha = _context.Departmans.Find(id);
            if (imha != null)
            {
                _context.Remove(imha);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
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
        public IActionResult DepartmanGetir(int id)
        {
            var value = _context.Departmans.Find(id);
            return View("DepartmanGetir", value);
        }
        public IActionResult DepartmanGuncelle(Departman d)
        {
            var value = _context.Departmans.Find(d.Id);
            value.DepartmanAdi = d.DepartmanAdi;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanDetay(int id)
        {
            var dep = _context.Departmans.Find(id);
            if (dep != null)
            {
                var values = _context.Personels.Include(u => u.Departman).Where(u=>u.Departman.Id==dep.Id).ToList();
                var dpt = _context.Departmans.Where(u => u.Id == id).Select(u => u.DepartmanAdi).FirstOrDefault();
                ViewBag.dpt = dpt;
                return View(values);
            }
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanPersonelSatis(int id)
        {
            var values = _context.SatisHarekets.Where(u=> u.Id == id).Include(u=> u.Urun).Include(u=>u.Cariler).ToList();
            var personel = _context.Personels.Where(u=>u.Id==id).Select(u=>u.PersonelAd + " " + u.PersonelSoyad).FirstOrDefault();
            ViewBag.id = id;
            ViewBag.personel = personel;
            return View(values);
        }
    }
}
