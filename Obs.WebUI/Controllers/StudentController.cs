using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Obs.Business.Abstract;
using Obs.WebUI.Models;

namespace Obs.WebUI.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LectureList()
        {
            var students = _studentService.GetAll();

            StudentListViewModel model = new StudentListViewModel
            {
                Students = students.ToList()
            };

            return View(model);
        }


    }
}