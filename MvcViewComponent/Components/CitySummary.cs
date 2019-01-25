using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcViewComponent.Models;
using System.Linq;

namespace MvcViewComponent.Components
{
    public class CitySummary:ViewComponent
    {
        private ICityRepository repository;

        //inject the dependency
        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }

        //public string Invoke()
        //{
        //    //return $"{repository.Cities.Count()} cities," + $"{repository.Cities.Sum(c => c.Population)} people";
        //    return ("This is a <h3><i>String</i><h3>"); //encoded, safe
        //}

        //public IViewComponentResult Invoke()
        //{

        //    //return View(new CityViewModel { Cities = repository.Cities.Count(), Population = repository.Cities.Sum(c => c.Population) });

        //    //return Content("This is a <h3><i>String</i><h3>"); //encoded, safe
        //    return new HtmlContentViewComponentResult(new HtmlString("This is a <h3><i>String</i><h3>"));//not encoded, unsafe
        //}

        public IViewComponentResult Invoke(bool showList)
        {
            if (showList)
            {
                return View("CityList", repository.Cities);
            }

            //using routing data to narrow the selection of City objects
            string target = RouteData.Values["id"] as string;
            var cities = repository.Cities.Where(City => target == null || string.Compare(City.Country, target, true) == 0);
            return View(new CityViewModel
            {
                Cities = cities.Count(),
                Population = cities.Sum(c => c.Population)
            });
        }
    }
}
