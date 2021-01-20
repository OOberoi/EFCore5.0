using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCCoreNewFeatues.Controllers
{
    public class ClassesController : Controller
    {
        // GET: ClassesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClassesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesController/Create
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

        // GET: ClassesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassesController/Edit/5
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

        // GET: ClassesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassesController/Delete/5
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
