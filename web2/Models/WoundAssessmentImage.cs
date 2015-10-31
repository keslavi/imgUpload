using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetHealth.WoundExpert.Documents;

namespace web2.Models
{
	public class woundAssessmentImage
	{
		public int? assessmentId { get; set; }
		public int? woundId { get; set; }
		public int? woundNumber { get; set; }
		public string patientName { get; set; }
		public string dos { get; set; }
		public Single? length { get; set; }
		public Single? width { get; set; }
		public Single? depth { get; set; }
		public string photoKey { get; set; }
		public List<image> images { get; set; }
		public WoundAssessmentDocument document { get; set; }
		public int imageNumber { get; set; }
		public string imageData { get; set; }
	}

	[Serializable]
	public class image
	{
		public int number { get; set; }
		public string data { get; set; }
	}
}

