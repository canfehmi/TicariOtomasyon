using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Entities;

namespace TicariOtomasyon.Views.Istatistik.ViewComponents
{
    public class _ComponentPartial4:ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = _context.Uruns.ToList();
            return View(values);
        }
    }
}
