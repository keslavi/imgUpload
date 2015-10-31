using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using web.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
	[Route("/[controller]")]
	public class HomeController : Controller
    {
        // GET: /<controller>/
		[HttpGet]
        public IActionResult Index()
		{
			var m =new Model1();
            return View(m);
        }
    }
}
