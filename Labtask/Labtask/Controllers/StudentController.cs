using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labtask.Controllers;
using Labtask.Models;
using Labtask.Models.Database;

namespace Labtask.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Create()
        {
            Student s = new Student();
            return View(s);
        }

        [HttpPost]

        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                Database d = new Database();
                d.Student.Insert(s);
                return RedirectToAction("AllStudent");

            }
            return View();
            
        }

        public ActionResult AllStudent()
        {
            Database db = new Database();
            var student= db.Student.GetAll();

            return View(student);
        }

        public ActionResult Edit(string Id)
        {
            Database db = new Database();
            var s = db.Student.Get(Id);
           

            return View(s);
        }

        [HttpPost]

        public ActionResult Edit(Student s)
        {
            Database d = new Database();
            d.Student.Update(s);
            return RedirectToAction("AllStudent");
        }

        public ActionResult Delete(string Id)
        {
            Database d = new Database();
            d.Student.Delete(Id);
            return RedirectToAction("AllStudent");
        }

        public ActionResult Login()
         {
             Student s = new Student();
             return View(s);
         } 
        [HttpPost]
        public ActionResult Login(Student s)
        {
            Database d = new Database();
            var a= d.Student.LogIn(s.UserName);
            if (a.UserName==s.UserName && a.password==s.password)
            {
                return RedirectToAction("AllStudent");
            }
            else
                return RedirectToAction("Create");


        }

    }
}