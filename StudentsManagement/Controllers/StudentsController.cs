using StudentsManagement.BLL;
using StudentsManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsManagement.Controllers
{
    public class StudentsController : Controller
    {
        /// <summary>
        /// Affichage de la list des étudiants
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<Student> students = new StudentBLO().FindAll();
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            new StudentBLO().Save(student);
            return RedirectToAction("Index");
        }
    }
}