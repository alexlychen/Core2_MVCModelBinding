#pragma checksum "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\Legacy\Common\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee4da54e40076577140cd5f2ffc1002cba8a565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Legacy_Common_Index), @"mvc.1.0.view", @"/Views/Legacy/Common/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Legacy/Common/Index.cshtml", typeof(AspNetCore.Views_Legacy_Common_Index))]
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
#line 1 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\_ViewImports.cshtml"
using MvcRazorViewEngine;

#line default
#line hidden
#line 2 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\_ViewImports.cshtml"
using MvcRazorViewEngine.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee4da54e40076577140cd5f2ffc1002cba8a565", @"/Views/Legacy/Common/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c00bf20bf6543c868e4ee8adec7377c29fc64a03", @"/Views/_ViewImports.cshtml")]
    public class Views_Legacy_Common_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\Legacy\Common\Index.cshtml"
  
    ViewData["Title"] = "Legancy Home Page";

#line default
#line hidden
            BeginContext(53, 61, true);
            WriteLiteral("\r\n<div class=\"m-1 p-1\">\r\n    This is a list of fruit names:\r\n");
            EndContext();
#line 7 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\Legacy\Common\Index.cshtml"
     foreach(string name in Model)
    {

#line default
#line hidden
            BeginContext(157, 17, true);
            WriteLiteral("        <span><b>");
            EndContext();
            BeginContext(175, 4, false);
#line 9 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\Legacy\Common\Index.cshtml"
            Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(179, 13, true);
            WriteLiteral("</b></span>\r\n");
            EndContext();
#line 10 "C:\Users\Chen\Documents\Visual Studio 2017\Projects\ASP.NET_Core2_MVC\MvcRazorViewEngine\Views\Legacy\Common\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(199, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
