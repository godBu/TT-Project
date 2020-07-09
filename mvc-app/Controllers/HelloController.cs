using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_app.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(); //Index() speaks to a file with the same name as our
            //views folder.
            //views/Hello: by default, it looks for index... just like any web server
            //View the name of the method
        }

        //GET: /HELLO/
        //public IActionResult Wassup() //our home for the controller
        //{
        //    return Wassup();
        //}

        //GET: /HELLO/WASSUP
        //public string Wassup(string name, int ID) // sub-view of out hello controller
        //{
        //    name = "Adam";
        //    ID = 1;
        //    return HtmlEncoder.Default.Encode($"Hello, {name} your ID is {ID}");
        //}
    }
}
