using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.CodeAnalysis.CSharp;
//using NetHealth.WoundExpert.DocumentUtilities;
//using NetHealth.WoundExpert.Documents;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
	[Route("api/[controller]")]
	public class WoundAssessmentController : Controller
	{
		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			//var doc=DocumentLibrary.Load<WoundAssessmentDocument>(234058);

			return "return=" + id.ToString();
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}

		[HttpPost]
		public Task<HttpResponse> Upload(int documentId)
		{
			//still identifying the mvc5 way to do it, but can still probably do it old school
			return null;
		}

	}
}
