#pragma checksum "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de27b6d241ef4f36d690bdd078c24f07b518de2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de27b6d241ef4f36d690bdd078c24f07b518de2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b054bcb44444ec8f0b0e1cc651602cf042bed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Mission9.Infrastructure.PageLinkTagHelper __Mission9_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
 foreach (var b in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1\">\r\n        <div class=\"bg-faded p-1\">\r\n            <h4>\r\n                ");
#nullable restore
#line 36 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
           Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                    <small>");
#nullable restore
#line 38 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                      Write(b.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </span>\r\n            </h4>\r\n        </div>\r\n        <div class=\"card-text p-1\">\r\n            <b>Author:</b> ");
#nullable restore
#line 43 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                      Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            <b>Publisher: </b> ");
#nullable restore
#line 44 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                          Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>ISBN:</b> ");
#nullable restore
#line 45 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                    Write(b.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>Classification:</b> ");
#nullable restore
#line 46 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                              Write(b.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>Category: </b> ");
#nullable restore
#line 47 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                         Write(b.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>Page Count:</b> ");
#nullable restore
#line 48 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                          Write(b.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>Price:</b> $");
#nullable restore
#line 49 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
                      Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de27b6d241ef4f36d690bdd078c24f07b518de27985", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Mission9_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::Mission9.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Mission9_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 53 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
__Mission9_Infrastructure_PageLinkTagHelper.PageModel = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Mission9_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Mission9_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "C:\Users\Maryn\Source\Repos\Mission9\WaterProject\WaterProject\Views\Home\Index.cshtml"
__Mission9_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Mission9_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Mission9_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Mission9_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Mission9_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
