using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class FaturaController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.Faturalars.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult FaturaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaturaEkle(Faturalar f)
        {
            _context.Faturalars.Add(f);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult FaturaGetir(int id)
        {
            var value = _context.Faturalars.FirstOrDefault(x => x.Id == id);
            return View(value);
        }
        [HttpPost]
        public IActionResult FaturaGetir(Faturalar f)
        {
            var value = _context.Faturalars.FirstOrDefault(x=>x.Id == f.Id);
            if (value != null)
            {
                value.FaturaSıraNo = f.FaturaSıraNo;
                value.FaturaSeriNo = f.FaturaSeriNo;
                value.FaturaTarih = f.FaturaTarih;
                value.TeslimAlan= f.TeslimAlan;
                value.TeslimEden = f.TeslimEden;
                value.Saat = f.Saat;
                value.VergiDairesi = f.VergiDairesi;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(value);            
        }
        public IActionResult FaturaDetay(int id)
        {
            var values = _context.FaturaKalems.Where(x=>x.Faturalar.Id == id).Include(x=>x.Faturalar).ToList();
            if (values != null)
            {
                var fatura = _context.Faturalars.Where(x=>x.Id==id).Select(u=>u.Id).FirstOrDefault();
                ViewBag.fatura = fatura;
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult KalemEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KalemEkle(FaturaKalem f)
        {
            var fatura = _context.Faturalars.Find(f.Faturalar.Id);
            if (fatura != null)
            {
                f.Faturalar = fatura;
                _context.FaturaKalems.Add(f);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
