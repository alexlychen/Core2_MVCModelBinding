using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcRazorViewEngine.Models;

namespace MvcRazorViewEngine.Controllers
{
    public class CommonController : Controller
    {
        public ViewResult Index() =>
            View("Index", new string[] { "Apple", "Orange", "Pear" });

        public ViewResult List() => View();
    }
}
