using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Index";
            return View();
        }

        public string Welcome(string name,int id) => $"Hello {name} and id param is {id}";

    }
}
