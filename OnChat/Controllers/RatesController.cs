using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnChat.Models;
using OnChat.Services;

namespace OnChat.Controllers
{
    public class RatesController : Controller
    {
        private IRateService service;


        public RatesController()
        {
            service = new RateService();
        }

        // GET: Rates
        public IActionResult Index()
        {
            return View(service.GetAll());
        }
        public IActionResult Search()
        {
            return View(service.GetAll());
        }

        [HttpPost]
        [ActionName("Search")]
        public IActionResult Search(string query)
        {

            return View(service.GetAllByName(query));
        }

        public IActionResult List()
        {
            return View(service.GetAll());
        }

        // GET: Rates/Details/5
        public IActionResult Details(string name)
        {
            return View(service.Get(name));
        }

        // GET: Rates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int rate, string feedback, string name)
        {
            service.Create(rate, feedback, name);
            return RedirectToAction(nameof(Index));
        }

        // GET: Rates/Edit/5
        public IActionResult Edit(string name)
        {
            return View(service.Get(name));
        }

        // POST: Rates/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int rate, string feedback, string name)
        {
            service.Edit(rate, feedback, name);
            return RedirectToAction(nameof(Index));
        }

        // GET: Rates/Delete/5
        public IActionResult Delete(string name)
        {

            return View(service.Get(name));
        }

        // POST: Rates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string name)
        {
            service.Delete(name);
            return RedirectToAction(nameof(Index));
        }
    }
}
