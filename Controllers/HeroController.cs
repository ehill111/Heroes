using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroProject.Data;
using SuperHeroProject.Models;

namespace SuperHeroProject.Controllers
{
    public class HeroController : Controller
    {
        private ApplicationDbContext db;
        public HeroController(ApplicationDbContext context)
        {
            db = context;
        }
        // GET: HeroController
        public ActionResult Index()
        {
            var heroes = db.Hero.ToList();

            //passing our list of heroes to the Index view
            return View(heroes);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            Hero HeroToView = db.Hero.Where(s => s.Id == id).SingleOrDefault();
            
            return View(HeroToView);
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

       

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                db.Hero.Add(hero);
                db.SaveChanges();
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
            return View();
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero HeroToEdit)
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

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroController/Delete/5
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
