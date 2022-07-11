using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Areas.Admin.Controllers
{
    [Area(areaName:"Admin")]
    public class TESTController : Controller
    {
        private readonly MedicalContext _medicalContext;
        public TESTController(MedicalContext medicalContext)
        {
            _medicalContext = medicalContext;
        }

        public IActionResult 樣板()
        {
            return View();
        }

        public IActionResult 中央空版()
        {
            return View();
        }
    }
}
