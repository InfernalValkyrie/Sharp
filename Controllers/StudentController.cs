using System;
using System.Web.Mvc;

namespace SharpDevelopMVC4.Controllers
{
	/// <summary>
	/// Description of StudentController.
	/// </summary>
	public class StudentController : Controller
	{
		public ActionResult Index()
		{	
			
			return View();
		}
		
		public ActionResult Register()
		{
			return View ();	
		}
		
		public ActionResult Save(string firstname, string lastname, string middlename, string course, string gender, string birthday)
		{
			ViewBag.FirstName = firstname;
			ViewBag.LastName = lastname;
			ViewBag.MiddleName = middlename;
			ViewBag.Course = course;
			ViewBag.Birthday = birthday;
			ViewBag.Gender = gender == "M" ? "Male" : "Female";
			
			
			return View ();
		}
	}
}