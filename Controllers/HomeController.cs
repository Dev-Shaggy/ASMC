using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdvancedSchoolManagment.Models;
using AdvancedSchoolManagment.Models.DbAccess;
using Microsoft.AspNetCore.Authorization;

namespace AdvancedSchoolManagment.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentDAL _student;

        public HomeController(ILogger<HomeController> logger, IStudentDAL student)
        {
            _logger = logger;
            _student = student;
        }

        public IActionResult Index()
        {
            //var list = _student.get();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
