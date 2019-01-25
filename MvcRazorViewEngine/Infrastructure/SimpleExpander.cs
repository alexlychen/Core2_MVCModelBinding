using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRazorViewEngine.Infrastructure
{
    public class SimpleExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            foreach (string location in viewLocations)
            {
                yield return location; //.Replace("Shared", "Common");  //replace shared with common
            }
            yield return "/Views/legacy/{1}/{0}.cshtml";  //the last one to be returned
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            //do nothing - not required
        }
    }
}
