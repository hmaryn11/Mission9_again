#pragma checksum "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53e4580d8223ca8a1f4320325974514716b4509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProjSummary), @"mvc.1.0.view", @"/Views/Shared/ProjSummary.cshtml")]
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
#line 3 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\_ViewImports.cshtml"
using Mission9.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\_ViewImports.cshtml"
using Mission9.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53e4580d8223ca8a1f4320325974514716b4509", @"/Views/Shared/ProjSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b054bcb44444ec8f0b0e1cc651602cf042bed", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProjSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
#nullable restore
#line 9 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"badge badge bg-info badge-primary\" style=\"float:right\">\r\n                <small>$");
#nullable restore
#line 11 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                   Write(Model.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">\r\n        <b>Author:</b> ");
#nullable restore
#line 16 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                  Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        <b>Publisher: </b> ");
#nullable restore
#line 17 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                      Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>ISBN:</b> ");
#nullable restore
#line 18 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Classification:</b> ");
#nullable restore
#line 19 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                          Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Category: </b> ");
#nullable restore
#line 20 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <b>Page Count:</b> ");
#nullable restore
#line 21 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Shared\ProjSummary.cshtml"
                      Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591