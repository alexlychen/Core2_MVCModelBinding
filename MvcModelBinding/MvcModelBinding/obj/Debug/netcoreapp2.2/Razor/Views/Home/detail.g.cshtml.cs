#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d004367b73d4b8ac5b669a4c5206d362d84bf54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_detail), @"mvc.1.0.view", @"/Views/Home/detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/detail.cshtml", typeof(AspNetCore.Views_Home_detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d004367b73d4b8ac5b669a4c5206d362d84bf54", @"/Views/Home/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b12648f85fe11c1070553e9894aa54635d4fa8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(62, 263, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h2 class=""display-4"">Welcome to MVC Model Binding</h2>

    <div class=""bg-primary m-1 p-1 text-white""><h2>Person</h2></div>

    <table class=""table table-sm table-bordered table-striped"">
        <tr><th>PersonId:</th><td>");
            EndContext();
            BeginContext(326, 14, false);
#line 13 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                             Write(Model.PersonId);

#line default
#line hidden
            EndContext();
            BeginContext(340, 48, true);
            WriteLiteral("</td></tr>\r\n        <tr><th>First Name:</th><td>");
            EndContext();
            BeginContext(389, 15, false);
#line 14 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(404, 47, true);
            WriteLiteral("</td></tr>\r\n        <tr><th>Last Name:</th><td>");
            EndContext();
            BeginContext(452, 14, false);
#line 15 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                              Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(466, 42, true);
            WriteLiteral("</td></tr>\r\n        <tr><th>Role:</th><td>");
            EndContext();
            BeginContext(509, 10, false);
#line 16 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                         Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(519, 42, true);
            WriteLiteral("</td></tr>\r\n        <tr><th>City:</th><td>");
            EndContext();
            BeginContext(562, 23, false);
#line 17 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                         Write(Model.HomeAddress?.City);

#line default
#line hidden
            EndContext();
            BeginContext(585, 45, true);
            WriteLiteral("</td></tr>\r\n        <tr><th>Country:</th><td>");
            EndContext();
            BeginContext(631, 26, false);
#line 18 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcModelBinding\MvcModelBinding\Views\Home\detail.cshtml"
                            Write(Model.HomeAddress?.Country);

#line default
#line hidden
            EndContext();
            BeginContext(657, 150, true);
            WriteLiteral("</td></tr>\r\n    </table>\r\n\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591