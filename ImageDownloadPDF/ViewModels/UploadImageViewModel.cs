using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ImageDownloadPDF.ViewModels
{
	public class UploadImageViewModel
	{
		[Required]
		[Display(Name = "Image")]
       
        public IFormFile SpeakerPicture { get; set; }
	}
}
