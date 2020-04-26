using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bitcoin_TCC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAzure.Models;
using Microsoft.EntityFrameworkCore;

namespace Bitcoin_TCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index
        {
            get
            {
                APIDetails api = new APIDetails();

                var viewModel = new APIDetails()
                {
                    BuyValueMessage = "O Valor atual do Bitcoin é: ",
                    Buy_Value_API = api.EnviaRequisicao_GET_()
                };

                return View(viewModel);
            }
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

        private Bitcoin_TCCContext db = new Bitcoin_TCCContext();

        //
        // GET: /ContatoKB/

        public ActionResult Index2()
        {
            return View(db.ContatoKB.ToList());
        }

        //
        // GET: /ContatoKB/Details/5

        public ActionResult Details(int id = 0)
        {
            ContatoKB ContatoKB = db.ContatoKB.Find(id);
            if (ContatoKB == null)
            {
                return HttpNotFound();
            }
            return View(ContatoKB);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        //
        // GET: /ContatoKB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ContatoKB/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContatoKB ContatoKB)
        {
            if (ModelState.IsValid)
            {
                db.ContatoKB.Add(ContatoKB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ContatoKB);
        }

        //
        // GET: /ContatoKB/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ContatoKB ContatoKB = db.ContatoKB.Find(id);
            if (ContatoKB == null)
            {
                return HttpNotFound();
            }
            return View(ContatoKB);
        }

        //
        // POST: /ContatoKB/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContatoKB ContatoKB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ContatoKB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ContatoKB);
        }

        //
        // GET: /ContatoKB/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ContatoKB ContatoKB = db.ContatoKB.Find(id);
            if (ContatoKB == null)
            {
                return HttpNotFound();
            }
            return View(ContatoKB);
        }

        //
        // POST: /ContatoKB/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContatoKB ContatoKB = db.ContatoKB.Find(id);
            db.ContatoKB.Remove(ContatoKB);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
