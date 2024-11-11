using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Views.Istatistik.ViewComponents
{
    public class _ComponentPartial2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var sorgu2 = (from x in context.Personels
                          group x by x.Departman.DepartmanAdi into g
                          select new SinifGrup2
                          {
                              Departman = g.Key,
                              Sayi = g.Count()
                          }).ToList();
            return View(sorgu2);
        }
    }
}
