using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class WoundAssessmentImageModel
    {
		public int WoundID { get; set; }

		[Display(Name="Patient:")]
		public string PatientName { get; set; }

		[Display(Name ="DOS:")]
		[DisplayFormat(DataFormatString ="{0:d}")]
		public DateTime DOS { get; set; }

		[Display(Name ="Wound:")]
		public string WoundNumber { get; set; }

		[DisplayFormat(DataFormatString ="{0:n2}", ApplyFormatInEditMode =true)]
		public decimal Length { get; set; }

		[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
		public decimal Width { get; set; }

		[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
		public decimal Depth { get; set; }

		[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
		public decimal Area { get { return this.Length * this.Width; } }

		[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
		public decimal Volume { get { return this.Length * this.Width * this.Depth; } }
    }
}
