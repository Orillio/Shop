using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageTagHelper : TagHelper
    {
        public IUrlHelperFactory helper { get; set; }
        public PageTagHelper(IUrlHelperFactory factory)
        {
            helper = factory;
        }
        public PagingInfo PageModel { get; set; }
        [ViewContext, HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public string PageAction { get; set; }
        
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-route-")]
        public Dictionary<string, object> UrlValues { get; set; } = new Dictionary<string, object>();
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassSecondary { get; set; }
        public string PageClassSelected { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = helper.GetUrlHelper(ViewContext);
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination");
            if (PageClassesEnabled)
            {
                ul.AddCssClass("pagination");
            }

            ul.InnerHtml.AppendHtml(this.GetArrow(ArrowType.Previous));

            for (int i = 1; i <= PageModel.TotalPages; i++) ul.InnerHtml.AppendHtml(this.GetPage(i));

            ul.InnerHtml.AppendHtml(this.GetArrow(ArrowType.Next));

            output.Content.AppendHtml(ul);
        }
        
    }
}
