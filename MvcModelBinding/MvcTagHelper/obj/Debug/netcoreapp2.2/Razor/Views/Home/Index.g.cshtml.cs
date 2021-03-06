#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e75bb0508c1b84586350b6a9408153856a68963"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\_ViewImports.cshtml"
using MvcTagHelper;

#line default
#line hidden
#line 2 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\_ViewImports.cshtml"
using MvcTagHelper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e75bb0508c1b84586350b6a9408153856a68963", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497a435d9d67f0afda279a7fc309f0cad8845f67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<City>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::MvcTagHelper.Infrastructure.TagHelpers.TableCellTagHelper __MvcTagHelper_Infrastructure_TagHelpers_TableCellTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 257, true);
            WriteLiteral(@"
<table class=""table table-sm table-bordered"">
    <thead class=""bg-primary text-white"">
        <tr>
            <th>Name</th>
            <th>Country</th>
            <th class=""text-right"">Population</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
         foreach(var city in Model)
        {

#line default
#line hidden
            BeginContext(378, 34, true);
            WriteLiteral("            <tr>\r\n                ");
            EndContext();
            BeginContext(412, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e75bb0508c1b84586350b6a9408153856a689634249", async() => {
                BeginContext(422, 9, false);
#line 19 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
                    Write(city.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __MvcTagHelper_Infrastructure_TagHelpers_TableCellTagHelper = CreateTagHelper<global::MvcTagHelper.Infrastructure.TagHelpers.TableCellTagHelper>();
            __tagHelperExecutionContext.Add(__MvcTagHelper_Infrastructure_TagHelpers_TableCellTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("wrap", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(436, 97, true);
            WriteLiteral(" <!--using tag helper \"wrap\" insert content before and after \"city.name\"-->\r\n                <td>");
            EndContext();
            BeginContext(534, 12, false);
#line 20 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
               Write(city.Country);

#line default
#line hidden
            EndContext();
            BeginContext(546, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(593, 34, false);
#line 21 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
                                  Write(city.Population?.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(627, 49, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr></tr>\r\n");
            EndContext();
#line 24 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcTagHelper\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(687, 81, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Home/Create\" class=\"btn btn-primary\">Create</a>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
