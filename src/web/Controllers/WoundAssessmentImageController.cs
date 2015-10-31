using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using web.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
	[Route("[controller]")]
	public class WoundAssessmentImageController : Controller
    {
        // GET: /<controller>/
		[HttpGet]
		[ActionName("Index")]
        public IActionResult Get(string patientName, DateTime dos, string woundNumber, decimal length, decimal width, decimal depth, int woundID)
        {
            return View(new WoundAssessmentImageModel()
						{
							WoundID = woundID,
							PatientName = patientName,
							DOS = dos,
							WoundNumber = woundNumber,
							Length = length,
							Width = width,
							Depth = depth
						});
        }
    }
}
