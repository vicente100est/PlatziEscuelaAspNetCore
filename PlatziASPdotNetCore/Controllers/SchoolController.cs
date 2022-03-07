using Microsoft.AspNetCore.Mvc;
using PlatziASPdotNetCore.Models;
using System;

namespace PlatziASPdotNetCore.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School();

            school.YearFoundationSchool = 2005;
            school.IdSchool = Guid.NewGuid().ToString();
            school.NameSchool = "Platzi School";

            return View(school);
        }
    }
}
