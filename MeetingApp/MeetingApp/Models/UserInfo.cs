using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
		public int id { get; set; }
		[Required(ErrorMessage ="Ad alanı Zorunlu")]
		[Display(Name ="İsim")]
        public string? Name { get; set; }
		[Required(ErrorMessage = "Telefon alanı Zorunlu")]
        [Display(Name = "Telefon No")]
        public string? Phone { get; set; }
		[Required(ErrorMessage = "Email alanı Zorunlu")]
		[EmailAddress(ErrorMessage = "Hatalı Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }
		[Required(ErrorMessage = "katılım durumunuzu belirtiniz.")]
		public bool WillAttend { get; set; }
    }
}
