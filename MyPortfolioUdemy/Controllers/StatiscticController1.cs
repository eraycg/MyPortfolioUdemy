using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatiscticController1 : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1=context.Skills1.Count();
            ViewBag.v2 = context.Messages1.Count();
            ViewBag.v3 = context.Messages1.Where(x=> x.IsRead== false).Count();
            ViewBag.v4 = context.Messages1.Where(x=> x.IsRead== true).Count();
            return View();
        }
    }
}
