using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Views.Istatistik.ViewComponents
{
    public class _ComponentPartial5:ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = from x in _context.Uruns
                         group x by x.Marka into g
                         select new SinifGrup3
                         {
                             Marka = g.Key,
                             Sayi = g.Count()
                         };
            return View(values.ToList());
        }
    }
}
