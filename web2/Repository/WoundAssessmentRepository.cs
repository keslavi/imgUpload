using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web2.Models;
using NetHealth.WoundExpert.Documents;
using NetHealth.WoundExpert.DocumentUtilities;

namespace web2.Repository
{
	class WoundAssessmentRepository:IDisposable	
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
		public web2.Models.woundAssessmentImage Get(int id)
		{
			var doc = DocumentLibrary.Load<WoundAssessmentDocument>(id, false);

			var imgList = new List<image>();
			imgList.Add(new image() { number = 1, data = "hi" });// data = GetBytes("test clear") });
			imgList.Add(new image() { number = 2, data = "hi" });// data = GetBytes("test clear") });
			var o = new woundAssessmentImage()
			{
				document = doc,
				assessmentId = doc.WoundAssessmentID.GetValueOrDefault(),
				photoKey = doc.PhotoKey,
				woundId = doc.WoundID.GetValueOrDefault(),
				images = imgList,
				patientName = doc.Properties.Patient.LastName + ", " + doc.Properties.Patient.FirstName,
				woundNumber = 1
				,
				dos = doc.Properties.DocumentDate
			};

			return o;
		}

		public void Dispose()
		{
			
		}
	}
}
