#pragma checksum "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85abedfa145447b0c4d1e93f0bc565bea112e453"
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
#line 1 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\_ViewImports.cshtml"
using CAProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\_ViewImports.cshtml"
using CAProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85abedfa145447b0c4d1e93f0bc565bea112e453", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a5e57a77a3e05fffddf6820fac83f035f5d91d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Home_AddToCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    PaginatedList<Product> paginatedList = (PaginatedList<Product>)ViewData["paginatedList"];
    var prevDisabled = !paginatedList.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !paginatedList.HasNextPage ? "disabled" : "";

    Dictionary<int, int> paginatedStockCount = (Dictionary<int, int>)ViewData["paginatedStockCount"];

    string changedCart = (string)ViewData["changedCart"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .product-container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
    }

    .product-item {
        display: grid;
        grid-template-areas: ""image"" ""name"" ""description"" ""add-to-cart"";
        grid-template-columns: 1fr;
        grid-template-rows: 3fr 0.5fr 3fr 1fr;
        align-content: center;
        justify-content: center;
        align-items: center;
        justify-items: center;
        border: 0.1rem solid black;
        height: 25rem;
        width: 20rem;
        margin: 0.5rem;
        padding-top: 0.5rem;
    }

        .product-item a {
            text-decoration: none;
        }

            .product-item a:hover {
                color: orange;
            }

        .product-item img {
            grid-area: image;
            width: 10rem;
            height: 10rem;
            padding: 0.2rem;
        }

        .product-item h5 {
            grid-area: name;
      ");
            WriteLiteral(@"      display: block;
            text-align: center;
            width: 17rem;
            max-height: 2rem;
            overflow: hidden;
            white-space: nowrap;
            text-overflow: ellipsis;
        }

        .product-item p {
            grid-area: description;
            text-align: justify;
            display: block;
            width: 17rem;
            max-height: 8rem;
            overflow: hidden;
            text-overflow: ellipsis;
        }

        .product-item button {
            grid-area: add-to-cart;
            width: 17rem;
            max-height: 4rem;
        }

            .product-item button:hover:enabled {
                background-color: orange;
                color: black;
            }
</style>


<div>
");
#nullable restore
#line 86 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
     if(changedCart == "true")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            if (sessionStorage.getItem(\"alerted\") == null) {\r\n                alert(\"Removed some items from your cart beacuse its sold out\");\r\n                sessionStorage.setItem(\"alerted\", \"yes\");\r\n            }\r\n        </script>\r\n");
#nullable restore
#line 94 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"product-container\">\r\n");
#nullable restore
#line 98 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
     foreach (Product product in paginatedList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-item\">\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2816, 1);
#nullable restore
#line 102 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2751, Url.Action("Index", "ProductPg", new { productid = product.Id }), 2751, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 2844, "", 2863, 1);
#nullable restore
#line 103 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2849, product.Image, 2849, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 2863, "", 2881, 1);
#nullable restore
#line 103 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2868, product.Name, 2868, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2965, "\"", 3037, 1);
#nullable restore
#line 107 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2972, Url.Action("Index", "ProductPg", new { productid = product.Id }), 2972, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>");
#nullable restore
#line 108 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </a>\r\n            </div>\r\n            <div>\r\n                <p>");
#nullable restore
#line 112 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div>\r\n");
#nullable restore
#line 115 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                 if (paginatedStockCount[product.Id] > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-primary add-to-cart\"");
            BeginWriteAttribute("product_id", " product_id=", 3371, "", 3394, 1);
#nullable restore
#line 117 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3383, product.Id, 3383, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"mr-1\">$");
#nullable restore
#line 117 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                                                                                                      Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>Add To Cart</button>\r\n");
#nullable restore
#line 118 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("value", " value=", 3545, "", 3563, 1);
#nullable restore
#line 121 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3552, product.Id, 3552, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" disabled>\r\n                        Out Of Stock\r\n                    </button>\r\n");
#nullable restore
#line 124 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 127 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85abedfa145447b0c4d1e93f0bc565bea112e45311875", async() => {
                WriteLiteral("\r\n    Previous\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              WriteLiteral(paginatedList.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3830, "btn", 3830, 3, true);
            AddHtmlAttributeValue(" ", 3833, "btn-default", 3834, 12, true);
#nullable restore
#line 132 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 3845, prevDisabled, 3846, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85abedfa145447b0c4d1e93f0bc565bea112e45314667", async() => {
                WriteLiteral("\r\n    Next\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
              WriteLiteral(paginatedList.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3976, "btn", 3976, 3, true);
            AddHtmlAttributeValue(" ", 3979, "btn-default", 3980, 12, true);
#nullable restore
#line 138 "C:\Users\SakuraDemon\Desktop\CAProject\CAProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 3991, nextDisabled, 3992, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85abedfa145447b0c4d1e93f0bc565bea112e45317553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
