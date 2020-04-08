using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bitcoin_TCC.Models;

namespace Bitcoin_TCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            APIDetails api = new APIDetails();

            var viewModel = new APIDetails()
            {
                BuyValueMessage = "O Valor atual do Bitcoin é: ",
                Buy_Value_API = api.EnviaRequisicao_GET_()

            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
