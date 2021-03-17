using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeros.Data;
using SuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeros.Controllers
{
    public class HeroController : Controller
    {
        private ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HeroController
        public ActionResult Index()
        {
            var hero = _context.Heroes;
            return View(hero);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            var hero = _context.Heroes.Find(id);
            return View(hero);
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero heroes)
        {
            try
            {
                _context.Heroes.Add(heroes);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            var hero = _context.Heroes.Find(id);
            return View(hero);
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hero heroes)
        {
            try
            {
                _context.Heroes.Update(heroes);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var hero = _context.Heroes.Find(id);
            return View(hero);
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Hero heroes)
        {
            try
            {
                _context.Heroes.Remove(heroes);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
