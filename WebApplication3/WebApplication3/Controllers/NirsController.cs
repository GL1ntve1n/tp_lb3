using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class NirsController : Controller
    {
        private static List<NirsModel> records = new List<NirsModel>
        {
            new NirsModel { ProjectName = "Проект 1", ResearchName = "Исследование 1", StudentName = "Иванов Иван", UniversityName = "МГУ", StartDate = new DateTime(2022, 1, 1), PhoneNumber = "+7 (111) 111-11-11" },
            new NirsModel { ProjectName = "Проект 2", ResearchName = "Исследование 2", StudentName = "Петров Петр", UniversityName = "МФТИ", StartDate = new DateTime(2022, 2, 1), PhoneNumber = "+7 (222) 222-22-22" },
            new NirsModel { ProjectName = "Проект 3", ResearchName = "Исследование 3", StudentName = "Сидоров Сидор", UniversityName = "СПбГУ", StartDate = new DateTime(2022, 3, 1), PhoneNumber = "+7 (333) 333-33-33" }
        };

        // GET: Nirs
        public ActionResult Index()
        {
            return View(records);
        }

        // GET: Nirs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nirs/Create
        [HttpPost]
        public ActionResult Create(NirsModel model)
        {
            if (ModelState.IsValid)
            {
                records.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Nirs/Delete/5
        public ActionResult Delete(int id)
        {
            var recordToDelete = records[id];
            return View(recordToDelete);
        }

        // POST: Nirs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                records.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nirs/Edit/5
        public ActionResult Edit(int id)
        {
            var recordToEdit = records[id];
            return View(recordToEdit);
        }

        // POST: Nirs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NirsModel model)
        {
            if (ModelState.IsValid)
            {
                records[id] = model;
                return RedirectToAction("Index");
            }
            return View(model);
        }

        

    }
}
