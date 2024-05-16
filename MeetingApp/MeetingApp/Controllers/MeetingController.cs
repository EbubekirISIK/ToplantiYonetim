using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class MeetingController : Controller
	{
		
		public IActionResult Apply()
		{
			return View();	
		}
		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
			if (ModelState.IsValid)
			{
				Repository.CreateUser(model);
				ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();	
				return View("Thanks", model);
			}
			else
			{
				return View(model);
			}
			
		}
		//[HttpPost] model eklemeden önce böyleydi.
		//public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend)
		//{
		//	Console.WriteLine(Name, Phone, Email,WillAttend);
		//	return View();
		//}
		public IActionResult List()
		{
			var users = Repository.Users;
			return View(users);
		}
		public IActionResult Details(int id) {
			return View(Repository.GetById(id));
		}
	}
}
