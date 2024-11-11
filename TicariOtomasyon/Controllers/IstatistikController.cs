using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Controllers
{
    public class IstatistikController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var d1 = context.Carilers.Count().ToString();
            ViewBag.d1= d1; 
            var d2 = context.Uruns.Where(u=>u.Durum==true).Count().ToString();
            ViewBag.d2= d2;
            var d3 = context.Personels.Count().ToString();
            ViewBag.d3= d3;
            var d4 = context.Kategoris.Count().ToString();
            ViewBag.d4= d4;
            var d5 = context.Uruns.Sum(x=>x.Stok).ToString();
            ViewBag.d5= d5;
            var d6 = (from x in context.Uruns select x.Marka).Distinct().Count().ToString();
            ViewBag.d6= d6;
            var d7 = context.Uruns.Count(x=>x.Stok<=20).ToString();
            ViewBag.d7= d7;
            var d8 = (from x in context.Uruns orderby x.SatisFiyat descending select x.UrunAd).FirstOrDefault();
            ViewBag.d8= d8;
            var d9 = (from x in context.Uruns orderby x.SatisFiyat select x.UrunAd).FirstOrDefault();
            ViewBag.d9= d9;
            var d10 = context.Uruns.Count(x => x.UrunAd == "Buzdolabı");
            ViewBag.d10= d10;
            var d11 = context.Uruns.Count(x => x.UrunAd == "Laptop");
            ViewBag.d11 = d11;
            var d12 = context.Uruns.GroupBy(x=>x.Marka).OrderByDescending(y=>y.Count()).Select(y=>y.Key).FirstOrDefault();
            ViewBag.d12= d12;
            var d13 = context.Uruns.Where(u=> u.Id == (context.SatisHarekets.GroupBy(x => x.Urun.Id).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault())).Select(u=>u.UrunAd).FirstOrDefault();
            ViewBag.d13= d13;
            var d14 = context.SatisHarekets.Sum(x=>x.ToplamTutar).ToString();
            ViewBag.d14= d14;
            DateTime bugun = DateTime.Today;
            var d15 = context.SatisHarekets.Count(x=>x.Tarih.Date==bugun).ToString();
            ViewBag.d15= d15;
            var d16 = context.SatisHarekets.Where(x=>x.Tarih.Date==bugun).Sum(x=>x.ToplamTutar);
            ViewBag.d16= d16;
            return View();
        }
        public IActionResult KolayTablolar()
        {
            return View();
        }
        public IActionResult Partial1()
        {
            var sorgu = (from x in context.Carilers
                         group x by x.CariSehir into g
                         select new SinifGrup
                         {
                             Sehir = g.Key,
                             Sayi = g.Count()
                         }).ToList();

            return PartialView("Partial1", sorgu);
        }
        public IActionResult Partial2()
        {
            var sorgu2 = (from x in context.Personels
                          group x by x.Departman.DepartmanAdi into g
                          select new SinifGrup2
                          {
                              Departman = g.Key,
                              Sayi = g.Count()
                          }).ToList();
            return PartialView("Partial2", sorgu2);
        }

    }
}
