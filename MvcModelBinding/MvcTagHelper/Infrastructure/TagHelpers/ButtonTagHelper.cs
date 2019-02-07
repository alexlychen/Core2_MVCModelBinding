using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTagHelper.Infrastructure.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")] //scope of the tag helper for "bs-button-color"
    [HtmlTargetElement("a", Attributes = "bs-button-color", ParentTag = "form")] //scope of the tag helper for "bs-button-color"
    public class ButtonTagHelper: TagHelper
    {
        public string BsButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
            //output.Attributes.SetAttribute("class", $"btn {BsButtonColor}");  //failed the test
        }
    }

}
