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

        public string Index()
        {
            return "Hello -> This is my default action...";
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