#pragma checksum "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567419c4468f904e3117f5da6c2947dcf6491301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Purchase), @"mvc.1.0.razor-page", @"/Pages/Purchase.cshtml")]
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
#line 2 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\_ViewImports.cshtml"
using Mission9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567419c4468f904e3117f5da6c2947dcf6491301", @"/Pages/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"131c8674a197e18756af42706c3d574d81a407ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Purchase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Your Cart</h1>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
         foreach (var i in Model.cart.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
                   Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
                   Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
                   Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
                    Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 888, "\"", 911, 1);
#nullable restore
#line 37 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Pages\Purchase.cshtml"
WriteAttributeValue("", 895, Model.ReturnUrl, 895, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission9.Pages.PurchaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission9.Pages.PurchaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission9.Pages.PurchaseModel>)PageContext?.ViewData;
        public Mission9.Pages.PurchaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
