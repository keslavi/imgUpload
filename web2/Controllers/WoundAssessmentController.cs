﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Web.Http;
using NetHealth.WoundExpert.DocumentUtilities;
using NetHealth.WoundExpert.Documents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using web2.Models;

namespace web2.Controllers
{
    public class WoundAssessmentController : ApiController
    {
		static byte[] GetBytes(string str)
		{
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

		static string GetString(byte[] bytes)
		{
			char[] chars = new char[bytes.Length / sizeof(char)];
			System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
			return new string(chars);
		}

		[HttpGet]
		public JToken Get(int id)
		{
//			int id = 234058;
            woundAssessmentImage doc = null;
			using (var db = new Repository.WoundAssessmentRepository())
			{
				doc = db.Get(id);
			}

				var ret = JsonConvert.SerializeObject(doc);
			//			JToken json = JObject.Parse(doc);
			JToken json = JObject.Parse(ret);
			return json;
		}

		[HttpPost]
		public JToken Post(dynamic model)
		{

			var ret=new message() {status="receiving data but need to finish writing"};
			

			return JObject.Parse(JsonConvert.SerializeObject(ret));
		}

		[Serializable]
		public class message
		{
			public string status { get; set; }
		}
	}
}
