#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63f9bbf2e41c543f8120f6bac4f9ce5eee72ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_CitySummary_CityList), @"mvc.1.0.view", @"/Views/Home/Components/CitySummary/CityList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/CitySummary/CityList.cshtml", typeof(AspNetCore.Views_Home_Components_CitySummary_CityList))]
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
#line 1 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\_ViewImports.cshtml"
using MvcViewComponent;

#line default
#line hidden
#line 2 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\_ViewImports.cshtml"
using MvcViewComponent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63f9bbf2e41c543f8120f6bac4f9ce5eee72ce0", @"/Views/Home/Components/CitySummary/CityList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d38b0f6164eab9489f3ba1ccc289071932b2561", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_CitySummary_CityList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<City>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 49, true);
            WriteLiteral("\r\n<table class=\"table table-sm table-bordered\">\r\n");
            EndContext();
#line 4 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml"
     foreach(var city in Model)
    {

#line default
#line hidden
            BeginContext(115, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(146, 9, false);
#line 7 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml"
           Write(city.Name);

#line default
#line hidden
            EndContext();
            BeginContext(155, 60, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(216, 33, false);
#line 9 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml"
           Write(city.Population.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(249, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 12 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml"
    }

#line default
#line hidden
            BeginContext(292, 80, true);
            WriteLiteral("    <tr>\r\n        <th>Total:</th>\r\n        <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(373, 26, false);
#line 16 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Home\Components\CitySummary\CityList.cshtml"
       Write(Model.Sum(p=>p.Population));

#line default
#line hidden
            EndContext();
            BeginContext(399, 38, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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
