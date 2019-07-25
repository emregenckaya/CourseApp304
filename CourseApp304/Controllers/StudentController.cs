using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp304.Data.Abstract;
using CourseApp304.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp304.Controllers
{
    public class StudentController : Controller
    {
        private IGenericRepository<Student> repository;
        private IStudentRepository repo;

        //private DataContext context;

        public StudentController(IGenericRepository<Student> _repository, IStudentRepository _repo)
        {
            repository = _repository;
            repo = _repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetTopStudents());   //default tolist geliyo gerek yok aslında
        }

        public IActionResult Create()
        {
            return View("StudentEditor");
        }

        public IActionResult Edit(int id)
        {

            return View("StudentEditor", repo.GetTopStudents().FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(Student entity)
        {
            if (entity.Id == 0)
            {
                repository.insert(entity);
            }
            else
            {
                repository.Update(entity);
            }
            //repository.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}