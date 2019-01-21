using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MvcModelBinding.Models
{

    //[Bind(nameof(City))]   //only bind "City"
    public class AddressSummary
    {
        //[BindRequired]
        public string City { get; set; }

        //[BindNever]
        public string Country { get; set; }
    }
}
