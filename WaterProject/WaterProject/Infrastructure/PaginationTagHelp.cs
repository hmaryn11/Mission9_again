﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission9.Models.ViewModels;

namespace Mission9.Infrastructure
{
    //[HtmlTargetElement("div",Attributes = "page-blah")] 
    //public class PaginationTagHelp : TagHelper
    //{
    //    //dynamically create page links
    //    private IUrlHelperFactory uhf;
    //    public PaginationTagHelp (IUrlHelperFactory temp)
    //    {
    //        uhf = temp;
    //    }
    //    [ViewContext]
    //    [HtmlAttributeNotBound]
    //    public ViewContext vc { get; set; }

    //    //Diff than View Context
    //    public PageInfo PageBlah { get; set; }
    //    public string PageAction { get; set; }
    //    public override void Process(TagHelperContext thc, TagHelperOutput tho)
    //    {
    //        IUrlHelper uh = uhf.GetUrlHelper(vc);

    //        TagBuilder final = new TagBuilder("div");

    //        for(int i = 1; i < PageBlah.TotalPages; i++)
    //        {
    //            TagBuilder tb = new TagBuilder("a"); //helps you build a tag

    //            tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
    //            tb.InnerHtml.Append(i.ToString());

    //            final.InnerHtml.AppendHtml(tb);

    //            tho.Content.AppendHtml(final.InnerHtml);
    //        }

    //    }
    //}
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }
        public override void Process(TagHelperContext context,
                TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction,
                   new { pageNum = i });
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage
                        ? PageClassSelected : PageClassNormal);
                }
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}

