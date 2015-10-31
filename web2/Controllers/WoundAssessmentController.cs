using System;
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
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Text;

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
		public JToken Get()
		{
			int id = 234058;
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
		public JToken Post([FromBody] woundAssessmentImage model)
		{
			//StringBuilder sb = new StringBuilder();
			//if (model != null)
			//{
			//	Base64ToImage(model.imageData);
			//	if (model.images != null)
			//	{
			//		sb.Append("Images list object not null");
			//	}
			//	else
			//		sb.Append("Images list object is null");
			//}

			var ret=new message() {status= (model == null) ? "failed" : "passed " + JsonConvert.SerializeObject(model).ToString()};
			

			return JObject.Parse(JsonConvert.SerializeObject(ret));
		}

		private static void Base64ToImage(string base64String)
		{
			// Convert Base64 String to byte[]
			byte[] imageBytes = Convert.FromBase64String(base64String);
			using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
			{
				// Convert byte[] to Image
				ms.Write(imageBytes, 0, imageBytes.Length);
				Image image = Image.FromStream(ms, true);
				image.Save(@"C:\Projects\temp\TempImage_BackFromServer.jpg", ImageFormat.Jpeg);
			}
		}

		[Serializable]
		public class message
		{
			public string status { get; set; }
		}
	}
}
