#pragma checksum "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21137f1ea945528741add8e2c57a283622279425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 2 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using booksite.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using booksite.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using booksite.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\_ViewImports.cshtml"
using booksite.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21137f1ea945528741add8e2c57a283622279425", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8b6ea04b22e9d06f2cd52011d1b232c0e1e52", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h3\">Shopping Cart</h1>\r\n<hr>\r\n");
#nullable restore
#line 5 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
 if(Model.CartItems.Count==0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"alert alert-warning\">\r\n                There are no books in your cart.\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""text-left"">
                <h4>Cart Items</h4>
            </div>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Image</th>
                        <th>Book Name</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 34 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21137f1ea945528741add8e2c57a2836222794257354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1061, "~/img/", 1061, 6, true);
#nullable restore
#line 38 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1067, item.ImageUrl, 1067, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                            Write(item.Quantity*item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21137f1ea945528741add8e2c57a28362227942510218", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1556, "\"", 1576, 1);
#nullable restore
#line 46 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1564, item.BookId, 1564, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1619, "\"", 1696, 11);
                WriteAttributeValue(" ", 1629, "return", 1630, 7, true);
                WriteAttributeValue(" ", 1636, "confirm(\'", 1637, 10, true);
#nullable restore
#line 47 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1646, item.Name, 1646, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1656, "Book", 1657, 5, true);
                WriteAttributeValue(" ", 1661, "are", 1662, 4, true);
                WriteAttributeValue(" ", 1665, "you", 1666, 4, true);
                WriteAttributeValue(" ", 1669, "sure", 1670, 5, true);
                WriteAttributeValue(" ", 1674, "you", 1675, 4, true);
                WriteAttributeValue(" ", 1678, "want", 1679, 5, true);
                WriteAttributeValue(" ", 1683, "to", 1684, 3, true);
                WriteAttributeValue(" ", 1686, "delete?\')", 1687, 10, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                    <i class=\"fa fa-times fa-fw\"></i>\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-4"">
            <div class=""text-left"">
                <h4>Cart Summary</h4>
            </div>
            <table class=""table"">
                <tbody>
                    <tr>
                        <th>Cart Total</th>
                        <td>");
#nullable restore
#line 65 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";</td>
                    </tr>
                    <tr>
                        <th>Shipping</th> 
                        <th>Free</th>
                    </tr>
                    <tr>
                        <th>Order Total</th> 
                        <th>");
#nullable restore
#line 73 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";</th>
                    </tr>
                </tbody>
            </table>
            <div class=""text-center"">
                <a href=""/"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-left fa-fw""></i>Continue Shopping
                </a>
                <a href=""/checkout"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-right fa-fw""></i>Checkout
                </a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 87 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
