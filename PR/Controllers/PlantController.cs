using PR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PR.Controllers
{
    public class PlantController : Controller
    {
        private PlantDbContext _db = new PlantDbContext();
        // GET: Plant
        public ActionResult Index()
        {
            ViewBag.data = _db.Color.ToList();

            var list = _db.Plants;
            return View(list.ToList());
        }

        //GET: Plant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plant plant)
        {
            if (ModelState.IsValid)
            {
                _db.Plants.Add(plant);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plant);
        }

        // GET: Plant/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Plant plant = _db.Plants.Find(id);
            if (plant == null)
            {
                return HttpNotFound();
            }
            return View(plant);
        }

        // POST: Plant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Plant plant = _db.Plants.Find(id);
            _db.Plants.Remove(plant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Plant/Edit/{id}
        // Get an id from the user
        // Handle if the id is null
        // Find Plant by that id
        // If the plant doesn't exist
        // Return the plant and the view
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Plant plant = _db.Plants.Find(id);
            if (plant == null)
            {
                return HttpNotFound();
            }
            return View(plant);
        }

        //POST: Plant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Plant plant)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(plant).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plant);
        }

        // GET: Plant/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Plant plant = _db.Plants.Find(id);
            if (plant == null)
            {
                return HttpNotFound();
            }
            return View(plant);
        }
    }
}