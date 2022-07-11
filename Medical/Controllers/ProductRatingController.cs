using Medical.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Controllers
{
    public class ProductRatingController : Controller
    {
        public IActionResult List()
        {
            MedicalContext medical = new MedicalContext();
            var result = from p in medical.Products
                         select p;

            return View(result.ToList());
        }

        public IActionResult AddRating()
        {
            return View();
        }

        public IActionResult test()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult AddRating()
        //{
        //    MedicalContext medical = new MedicalContext();
        //    var result = from p in medical.Products
        //                 select p;

        //    return View(result.ToList());
        //}



    }
}
