using Microsoft.AspNetCore.Mvc;

namespace StudentPlanner.Web.Controllers
{
    public class AssignmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}