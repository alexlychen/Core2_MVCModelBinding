#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Shared\Components\CitySummary\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4296d5054e5328c61e297ea3249ca031c6db3e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CitySummary_default), @"mvc.1.0.view", @"/Views/Shared/Components/CitySummary/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CitySummary/default.cshtml", typeof(AspNetCore.Views_Shared_Components_CitySummary_default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4296d5054e5328c61e297ea3249ca031c6db3e67", @"/Views/Shared/Components/CitySummary/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d38b0f6164eab9489f3ba1ccc289071932b2561", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CitySummary_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 137, true);
            WriteLiteral("\r\n<table class=\"table table-condensed table-bordered\">\r\n    <tr>\r\n        <td>Cities:</td>\r\n        <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(160, 12, false);
#line 7 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Shared\Components\CitySummary\default.cshtml"
       Write(Model.Cities);

#line default
#line hidden
            EndContext();
            BeginContext(172, 99, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Population:</td>\r\n        <td class=\"text-right\">");
            EndContext();
            BeginContext(272, 34, false);
#line 12 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcViewComponent\Views\Shared\Components\CitySummary\default.cshtml"
                          Write(Model.Population.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(306, 26, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
