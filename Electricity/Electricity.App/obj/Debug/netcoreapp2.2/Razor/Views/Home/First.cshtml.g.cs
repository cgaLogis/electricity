#pragma checksum "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bf780989ad3142ca55c915faa748dc74d0c6ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_First), @"mvc.1.0.view", @"/Views/Home/First.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/First.cshtml", typeof(AspNetCore.Views_Home_First))]
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
#line 1 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\_ViewImports.cshtml"
using Electricity.App;

#line default
#line hidden
#line 2 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\_ViewImports.cshtml"
using Electricity.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bf780989ad3142ca55c915faa748dc74d0c6ed", @"/Views/Home/First.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cb31d8ba8feb91b0355e914b6b3d965c731f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_First : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
  
    ViewData["Title"] = "First";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 25, true);
            WriteLiteral("\r\n<h1>First</h1>\r\n\r\n<div>");
            EndContext();
            BeginContext(116, 13, false);
#line 9 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
Write(ViewBag.items);

#line default
#line hidden
            EndContext();
            BeginContext(129, 6, true);
            WriteLiteral("</div>");
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
