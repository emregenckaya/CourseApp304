﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp304.Data.Abstract;
using CourseApp304.Data.Concrete;
using CourseApp304.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp304.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repository;

        public CourseController(ICourseRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index(string name=null,decimal? price=null,string isActive=null,string instructorName=null)
        {
            Console.Clear();

            var course = repository.GetCourseByFilter(name, price, isActive,instructorName);
            ViewBag.Name = name;
            ViewBag.Price = price;
            ViewBag.isActive = isActive == "on" ? true : false;
            ViewBag.InstructorName = instructorName;

            return View(course);
        }

        [HttpGet]   //default olarak get gelir
        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Course entity, Course original)
        {
            repository.UpdateCourse(entity, original);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Course());
        }

        [HttpPost]
        public IActionResult Create(Course newCourse)
        {
            int id = repository.CreateCourse(newCourse);
            Console.WriteLine("Id: {0}", id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Console.Clear();
            
            repository.DeleteCourse(id);
            return RedirectToAction("Index");

        }
    }
}