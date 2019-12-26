using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Obs.Business.Abstract;
using Obs.Entities.Concrete;
using Obs.WebUI.Models;

namespace Obs.WebUI.Controllers
{
    [Authorize(Roles="Teacher")]
    public class TeacherController : Controller
    {
        private IProgramService _programService;
        private IFacultyService _facultyService;
        private IStudentService _studentService;
        private ITeacherService _teacherService;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new StudentAddViewModel
            {
                Student = new Student()
               
            };
            return View(model);
        }
    }
}