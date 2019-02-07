using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTagHelper.Infrastructure.TagHelpers
{

    [HtmlTargetElement("div", Attributes = "title")]
    public class ContentWrapperTagHelper : TagHelper
    {
        public bool IncludeHeader { get; set; } = true;
        public bool IncludeFooter { get; set; } = true;

        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "m-1 p-1");

            TagBuilder title = new TagBuilder("h1");
            title.InnerHtml.Append(Title);         //title = "<h1 class="m-1 p-1">Title</h1>"

            TagBuilder container = new TagBuilder("div");
            container.Attributes["class"] = "bg-info m-1 p-1";
            container.InnerHtml.AppendHtml(title);         //container = <div class="bg-info m-1 p-1">title</div>
                                                           //container = <div class="bg-info m-1 p-1"><h1 class="m-1 p-1">Title</h1></div>
            if (IncludeHeader)
            {
                output.PreElement.SetHtmlContent(container); //put element before another element
            }
            if (IncludeFooter)
            {
                output.PostElement.SetHtmlContent(container); //put element after another element
            }
        }
    }
}
