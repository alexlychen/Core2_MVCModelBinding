using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcModelBinding.Models;

namespace MvcModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.People); //if id = 0, exception raised 
        }

        //public IActionResult Index([FromRoute]int id)
        //{
        //    return View(repository[id] ?? repository.People.First()); // if id = 0, return the first element of the repository
        //}

        //https://localhost:5001/home/index/3?id=1
        public IActionResult Detail([FromQuery]int? id)  //id=1, binding the query string
        {
            Person person;

            if (id.HasValue) //if id = null, return bad request 
            {
                if ((person = repository[id.Value]) != null) //if person = null, return page not found 
                {
                    return View(person);
                }

                return NotFound();
            }

            return BadRequest();
        }

        public ViewResult Create() => View(new Person());

        [HttpPost]
        public ViewResult Create(Person model) => View("index", model);

        //Specify the prefix during model binding, only bind "City"
        public ViewResult DisplaySummary([Bind(/*nameof(AddressSummary.City),*/ Prefix = nameof(Person.HomeAddress))] AddressSummary addressSummary)
            => View(addressSummary);

        //This action method can accept [HttpGet] and [HttpPost], all other Http methods
        public ViewResult Names(string[] names) => View(names ?? new string[0]);

        public ViewResult Lists(IList<string> names) => View(names ?? new List<string>());

        public ViewResult Address(IList<AddressSummary> addresses) => View(addresses ?? new List<AddressSummary>());

        //From Header
        public string Header([FromHeader] string accept) => $"Header:{accept }";

        public string Header2([FromHeader(Name ="Accept-Language")] string accept) => $"Header:{accept }";

        public ViewResult HeaderModel(HeaderModel model) => View(model);


        public ViewResult Body() => View();

        //From body
        [HttpPost]
        public Person Body([FromBody]Person model) => model;








        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
