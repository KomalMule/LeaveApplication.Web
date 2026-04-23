using LeaveApplication.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApplication.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                name = "Komal Ramesh Mule",
                DateOfBirth = new DateTime(2005,02,24)
            };


            return View(data);
        }
    }
}
