#pragma checksum "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fc7265ebe9c9dac959b302d960e5ea203cf13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductItem), @"mvc.1.0.view", @"/Views/Shared/ProductItem.cshtml")]
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
#line 1 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\_ViewImports.cshtml"
using Shop.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2fc7265ebe9c9dac959b302d960e5ea203cf13d", @"/Views/Shared/ProductItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e83aa5651736ce1b113779d6e565dde23342dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"products__item\">\r\n");
#nullable restore
#line 4 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
    if (Model.IsDiscount)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"discount\">\r\n            <span>");
#nullable restore
#line 7 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
              Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n        </div>\r\n");
#nullable restore
#line 9 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2fc7265ebe9c9dac959b302d960e5ea203cf13d4620", async() => {
                WriteLiteral("\r\n        \r\n        <div class=\"product_img_wrapper\">\r\n            <img class=\"product_img\"");
                BeginWriteAttribute("src", " src=\"", 363, "\"", 389, 2);
                WriteAttributeValue("", 369, "../", 369, 3, true);
#nullable restore
#line 13 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
WriteAttributeValue("", 372, Model.ImageUrl, 372, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"sofa\">\r\n        </div>\r\n        <div class=\"short_desc\">\r\n            <p>");
#nullable restore
#line 16 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
             if (Model.IsDiscount)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h5><s style=\"color: #aaa;\">");
#nullable restore
#line 19 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;руб</s></h5>\r\n");
#nullable restore
#line 20 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h5>");
#nullable restore
#line 21 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
            Write(Model.DiscountPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;руб</h5>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\Yan\Desktop\C# related\Shop\ShopBack\Shop\Views\Shared\ProductItem.cshtml"
                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591