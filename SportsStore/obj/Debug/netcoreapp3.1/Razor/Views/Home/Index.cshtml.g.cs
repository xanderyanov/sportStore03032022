#pragma checksum "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6356b231710d61c5f4e234e6784ae17e41be32b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\SportStoreFolder\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6356b231710d61c5f4e234e6784ae17e41be32b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a111b9c4ef516ed99a5cb0b1b25efb3018c303", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml"
 foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 5 "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        ");
#nullable restore
#line 6 "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml"
   Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h4>");
#nullable restore
#line 7 "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 9 "D:\SportStoreFolder\SportsSln\SportsStore\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
