using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Controllers
{
    public class ClinicDetailController : Controller
    {
        int doctorId = 1;
        private readonly MedicalContext _medicalContext;
        public ClinicDetailController(MedicalContext medicalContext)
        {
            _medicalContext = medicalContext;
        }
        public IActionResult List()
        {
            List<CClinicDetailViewModel> list = new List<CClinicDetailViewModel>();
            var result = _medicalContext.ClinicDetails.Where(x => x.DoctorId.Equals(doctorId));

            foreach (var c in result)
            {
                CClinicDetailViewModel cc = new CClinicDetailViewModel();
                cc.clinicDetail = c;
                list.Add(cc);
            }
            return View(list.ToList());
        }

        public IActionResult workSpace()
        {
            return View();
        }
    }
}
