using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public IActionResult About(string name, int age, int rate)
        {
            ViewData["Name"] = "My name is " + name;
            ViewData["Age"] =  "I am " + age + " years old";
            ViewData["Rate"] = rate;
            return View(); 
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, numTimes = {numTimes}"); 
        //}
    }
}
