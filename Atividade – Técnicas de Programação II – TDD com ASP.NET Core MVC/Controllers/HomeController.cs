using Atividade___Técnicas_de_Programação_II___TDD_com_ASP.NET_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Atividade___Técnicas_de_Programação_II___TDD_com_ASP.NET_Core_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
