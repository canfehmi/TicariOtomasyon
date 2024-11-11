using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Views.Istatistik.ViewComponents
{
    public class _ComponentPartial1:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var sorgu = (from x in context.Carilers
                         group x by x.CariSehir into g
                         select new SinifGrup
                         {
                             Sehir = g.Key,
                             Sayi = g.Count()
                         }).ToList();
            return View(sorgu);
        }
    }
}
