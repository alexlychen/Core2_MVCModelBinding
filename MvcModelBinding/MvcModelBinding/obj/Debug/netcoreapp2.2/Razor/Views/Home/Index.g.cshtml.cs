#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d68a23cfb5457c673d3590fd1e683d1cb6263f"
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
#line 1 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\_ViewImports.cshtml"
using MvcModelBinding;

#line default
#line hidden
#line 2 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\_ViewImports.cshtml"
using MvcModelBinding.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d68a23cfb5457c673d3590fd1e683d1cb6263f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b12648f85fe11c1070553e9894aa54635d4fa8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 166, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h2 class=\"display-4 text-center\">Welcome to MVC Model Binding</h2>\r\n\r\n    <div class=\"bg-primary m-1 p-1 text-white\"><h2>People</h2></div>\r\n");
            EndContext();
#line 11 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
     foreach (Person person in Model)
    {

#line default
#line hidden
            BeginContext(287, 107, true);
            WriteLiteral("        <table class=\"table table-sm table-bordered table-striped\">\r\n            <tr><th>PersonId:</th><td>");
            EndContext();
            BeginContext(395, 15, false);
#line 14 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                                 Write(person.PersonId);

#line default
#line hidden
            EndContext();
            BeginContext(410, 52, true);
            WriteLiteral("</td></tr>\r\n            <tr><th>First Name:</th><td>");
            EndContext();
            BeginContext(463, 16, false);
#line 15 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                                   Write(person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(479, 51, true);
            WriteLiteral("</td></tr>\r\n            <tr><th>Last Name:</th><td>");
            EndContext();
            BeginContext(531, 15, false);
#line 16 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                                  Write(person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(546, 46, true);
            WriteLiteral("</td></tr>\r\n            <tr><th>Role:</th><td>");
            EndContext();
            BeginContext(593, 11, false);
#line 17 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                             Write(person.Role);

#line default
#line hidden
            EndContext();
            BeginContext(604, 46, true);
            WriteLiteral("</td></tr>\r\n            <tr><th>City:</th><td>");
            EndContext();
            BeginContext(651, 24, false);
#line 18 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                             Write(person.HomeAddress?.City);

#line default
#line hidden
            EndContext();
            BeginContext(675, 49, true);
            WriteLiteral("</td></tr>\r\n            <tr><th>Country:</th><td>");
            EndContext();
            BeginContext(725, 27, false);
#line 19 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
                                Write(person.HomeAddress?.Country);

#line default
#line hidden
            EndContext();
            BeginContext(752, 30, true);
            WriteLiteral("</td></tr>\r\n        </table>\r\n");
            EndContext();
#line 21 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(789, 126, true);
            WriteLiteral("\r\n\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
