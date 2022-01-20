using Microsoft.AspNetCore.Mvc;
using Mission02_GradeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission02_GradeCalculator.Controllers
{
    public class GCalcController : Controller
    {
        public IActionResult Index ()
        {
            //throw new IndexOutOfRangeException(); <- this is a way to test with an error

            return View();
        }

        [HttpGet]
        public IActionResult CalcForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcForm (CalcFormModel model)
        {
            return View();
        }
    }
}
