using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
			var meetinInfo = new MeetingInfo()
			{
				id = 1,
				Location = "İstanbul, abc Kongre Merkezi",
				Date = new DateTime(2024, 01, 20, 20, 0, 0),
				NumberOfPeople = UserCount
			};
			return View(meetinInfo);
		}
	}
}
