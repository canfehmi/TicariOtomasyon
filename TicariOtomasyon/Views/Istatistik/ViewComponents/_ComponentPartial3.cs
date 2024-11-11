using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Views.Istatistik.ViewComponents
{
    public class _ComponentPartial3:ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = _context.Carilers.Where(u=>u.Durum==true).ToList();
            return View(values);
        }
    }
}
