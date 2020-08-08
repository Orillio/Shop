using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Shop.Models
{
    public enum ArrowType { Previous, Next}

    public static class PaginationModel
    {
        public static IHtmlContent GetArrow(this PageTagHelper tagHelper, ArrowType arrowType)
        {
            IUrlHelper urlHelper = tagHelper.helper.GetUrlHelper(tagHelper.ViewContext);
            TagBuilder li = new TagBuilder("li");
            if (arrowType == ArrowType.Next)
            {
                if (tagHelper.PageModel.CurrentPage == tagHelper.PageModel.TotalPages) return null;

                tagHelper.UrlValues["page"] = tagHelper.PageModel.CurrentPage + 1;

            }
            else
            {
                if (tagHelper.PageModel.CurrentPage == 1) return null;

                tagHelper.UrlValues["page"] = tagHelper.PageModel.CurrentPage - 1;
            }
            TagBuilder a = new TagBuilder("a");
            a.Attributes["href"] = urlHelper.Action("Index", tagHelper.UrlValues);
            if (arrowType == ArrowType.Next)
            {
                a.InnerHtml.Append(">");
            }
            else
            {
                a.InnerHtml.Append("<");
            }
            li.InnerHtml.AppendHtml(a);
            if (tagHelper.PageClassesEnabled) li.AddCssClass("page page_secondary");
            return li;
        }
        public static IHtmlContent GetPage(this PageTagHelper tagHelper, int page)
        {
            IUrlHelper urlHelper = tagHelper.helper.GetUrlHelper(tagHelper.ViewContext);
            TagBuilder li = new TagBuilder("li");
            tagHelper.UrlValues["page"] = page;
            TagBuilder a = new TagBuilder("a");
            a.Attributes["href"] = urlHelper.Action("Index", tagHelper.UrlValues);
            a.InnerHtml.Append($"{page}");
            li.InnerHtml.AppendHtml(a);
            if (tagHelper.PageClassesEnabled)
            {
                li.AddCssClass("page");
                if (tagHelper.PageModel.CurrentPage == page)
                {
                    li.AddCssClass("page_active");
                }
                else
                {
                    li.AddCssClass("page_secondary");
                }
            }
            return li;
        }
    }
}
