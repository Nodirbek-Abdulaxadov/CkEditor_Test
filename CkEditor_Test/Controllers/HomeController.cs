using CkEditor_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace CkEditor_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(CKModel model)
        {
            return View(model);
        }
    }
}