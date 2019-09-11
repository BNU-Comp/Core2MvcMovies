using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcMovies2019.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public string Message()
        {
            string message = "<section class='jumbotron'><h1>Hello Index View</h1></section>";

            return message;
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return "Hello -> This is the Welcome action method...";
        }
    }
}