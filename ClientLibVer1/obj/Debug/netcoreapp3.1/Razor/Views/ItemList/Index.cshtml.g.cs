#pragma checksum "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebca6a2c89137d52d61bb219ffa3da63b742b353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemList_Index), @"mvc.1.0.view", @"/Views/ItemList/Index.cshtml")]
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
#line 1 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\_ViewImports.cshtml"
using ClientLibVer1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\_ViewImports.cshtml"
using ClientLibVer1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebca6a2c89137d52d61bb219ffa3da63b742b353", @"/Views/ItemList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ece483981638bbe570d4af595ddb4e2b987481b", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientLibViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml"
  
    ViewData["Title"] = "Items List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> View check</h1>\r\n\r\n<div class=\"container\">\r\n    <table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <td>ItemId</td>\r\n            <td>OwnerId</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml"
         foreach (var item in Model.Itemcolection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n               \r\n                <td>");
#nullable restore
#line 21 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml"
               Write(item.ItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml"
               Write(item.OwnerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Marcin\Source\Repos\ClientApiConectionVer1\ClientLibVer1\Views\ItemList\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    </table>\r\n</div>");
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
