#pragma checksum "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbe75d2cfacbbda1bf3b479cb2008d127a0c684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RecordList_Index), @"mvc.1.0.view", @"/Views/RecordList/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\_ViewImports.cshtml"
using ClientLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\_ViewImports.cshtml"
using ClientLib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbe75d2cfacbbda1bf3b479cb2008d127a0c684", @"/Views/RecordList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d7bbd5833fc3ec261c00a7a6446f5237104923", @"/Views/_ViewImports.cshtml")]
    public class Views_RecordList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientLibViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
  
    ViewData["Title"] = "Records List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1> View check</h1>

<div class=""container"">
    <table class=""table table-hover"">
        <thead>
            <tr>

                <td>RecordId</td>
                <td>ItemId</td>
                <td>UserId</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
             foreach (var item in Model.RecordCollection)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
                   Write(item.RecordId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
                   Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
                   Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Marcin\source\repos\ClientApiConectionVer1\ClientLibVer1\Views\RecordList\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientLibViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
