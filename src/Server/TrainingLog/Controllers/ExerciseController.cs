using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingLog.Factory;
using TrainingLog.Repository.Interface;
using TrainingLog.Model;

namespace TrainingLog.Controllers
{
    public class ExerciseController : Controller
    {
        // GET: Exercise
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Statistics()
        {
            return View();
        }

        public ActionResult List()
        {
            RepositoryFactory factory = new RepositoryFactory();
            IExerciseRepository repo = factory.GetExerciseRepo();

            List<Exercise> exercises = repo.GetExcercises();

            ViewBag.Exercises = exercises;

            return View();
        }

        // GET: Exercise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exercise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exercise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exercise/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exercise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exercise/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
