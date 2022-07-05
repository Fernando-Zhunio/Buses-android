using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace buses2.Controllers
{
    public class BusesController : Controller
    {
        // GET: BusesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BusesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BusesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
