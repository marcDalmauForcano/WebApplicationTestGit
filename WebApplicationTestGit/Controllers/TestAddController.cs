using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTestGit.Controllers
{
    public class TestAddController : Controller
    {
        // GET: TestAddController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestAddController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestAddController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestAddController/Create
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

        // GET: TestAddController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestAddController/Edit/5
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

        // GET: TestAddController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestAddController/Delete/5
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
