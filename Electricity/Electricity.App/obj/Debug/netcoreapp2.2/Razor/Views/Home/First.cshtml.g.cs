#pragma checksum "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b139c7f5a2d161b8191c7b144ddc97d47990dbbe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b139c7f5a2d161b8191c7b144ddc97d47990dbbe", @"/Views/Home/First.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cb31d8ba8feb91b0355e914b6b3d965c731f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_First : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
  
    ViewData["Title"] = "First";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(105, 390, true);
            WriteLiteral(@"
<h1>Задание №1</h1>

<div class=""container"">
    <div class=""col-md-12"">
        <table class=""table"">
            <thead>
                <tr>
                    <th class=""text-black-50"">Id</th>
                    <th class=""text-black-50"">NUmber</th>
                    <th class=""text-black-50"">Date</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
                 foreach ( var item in Model.Items )
                {

#line default
#line hidden
            BeginContext(568, 95, true);
            WriteLiteral("                    <tr class=\"d-table-row\">\r\n                        <td class=\"d-table-cell\">");
            EndContext();
            BeginContext(664, 7, false);
#line 23 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(671, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"d-table-cell\">");
            EndContext();
            BeginContext(728, 11, false);
#line 24 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
                                            Write(item.Number);

#line default
#line hidden
            EndContext();
            BeginContext(739, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"d-table-cell\">");
            EndContext();
            BeginContext(796, 19, false);
#line 25 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
                                            Write(item.ValidationDate);

#line default
#line hidden
            EndContext();
            BeginContext(815, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 27 "V:\GitHub\Electricity\Electricity\Electricity.App\Views\Home\First.cshtml"
                }

#line default
#line hidden
            BeginContext(868, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
