using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web2.Models;

namespace web2.Controllers
{
	public class WoundAssessmentImageController : Controller
	{
		[HttpGet]
		public ActionResult Index(int id)
		{
			//int id = 234058;
			woundAssessmentImage doc = null;
			using (var db = new Repository.WoundAssessmentRepository())
			{
				doc = db.Get(id);
			}
			return View(doc);
		}

		[HttpGet]
		public ActionResult Get(int id)
		{
			//int id = 234058;
			woundAssessmentImage doc = null;
			using (var db = new Repository.WoundAssessmentRepository())
			{
				doc = db.Get(id);
			}
			return View("Index",doc);
		}
		[HttpPost]
		public ActionResult Post(int assessmentId)
		{
			var r = Request.Form;
			//save the pics and return crap

			woundAssessmentImage doc = null;
			using (var db = new Repository.WoundAssessmentRepository())
			{
				doc = db.Get(assessmentId);
			}
			ViewBag["message"] = "post complete";
			return View("Index", doc);
		}
		//public ActionResult Get(string patientName, DateTime dos, string woundNumber, decimal length, decimal width, decimal depth, int woundID)
		//{
		//	var ret = new web2.Models.woundAssessmentImage()
		//	{ 


		//	};

		//	return View(new web2.Models.woundAssessmentImage()
		//			{
		////				woundId = woundID,

		//				//patientName = patientName,
		//				//   = dos,
		//				//WoundNumber = woundNumber,
		//				//Length = length,
		//				//Width = width,
		//				//Depth = depth
		//			});
		//		}

	}
}