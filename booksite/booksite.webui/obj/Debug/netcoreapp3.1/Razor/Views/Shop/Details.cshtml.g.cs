#pragma checksum "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3a791a9e83329e80d37320e96b13489bcc2861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3a791a9e83329e80d37320e96b13489bcc2861", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8b6ea04b22e9d06f2cd52011d1b232c0e1e52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link p-0 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b3a791a9e83329e80d37320e96b13489bcc28616910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 91, "~/img/", 91, 6, true);
#nullable restore
#line 5 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 97, Model.Book.ImageUrl, 97, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">                \r\n        <h1 class=\"mb-3\">");
#nullable restore
#line 8 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                    Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> <hr>\r\n");
#nullable restore
#line 9 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b3a791a9e83329e80d37320e96b13489bcc28619066", async() => {
#nullable restore
#line 11 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                                                               WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
#nullable restore
#line 12 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\"> \r\n            <strong>&nbsp;&nbsp;&nbsp;Author</strong>:<a class=\"text-primary\"");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 598, 2);
            WriteAttributeValue("", 564, "/books/author/", 564, 14, true);
#nullable restore
#line 14 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 578, Model.Book.AuthorId, 578, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 14 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                                                                                                                    Write(Model.Authors.FirstOrDefault(x => x.AuthorId == Model.Book.AuthorId).NameLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> &nbsp; &nbsp; &nbsp; &nbsp;\r\n            <strong>Publisher</strong>:<a class=\"text-primary\"");
            BeginWriteAttribute("href", " href=\"", 779, "\"", 826, 2);
            WriteAttributeValue("", 786, "/books/publisher/", 786, 17, true);
#nullable restore
#line 15 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 803, Model.Book.PublisherId, 803, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 15 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                                                                                                           Write(Model.Publishers.FirstOrDefault(x => x.PublisherId == Model.Book.PublisherId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>                    \r\n        </div>   \r\n        <hr>\r\n        <div class=\"mb-3\">\r\n            <h3 class=\"text-primary mb-3\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
           Write(Model.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n            </h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b3a791a9e83329e80d37320e96b13489bcc286114318", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1249, "\"", 1275, 1);
#nullable restore
#line 23 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 1257, Model.Book.BookId, 1257, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""input-group mb-3"">
                    <input type=""number"" name=""quantity"" class=""form-control"" value=""1"" min=""1"" step=""1"" style=""width: 100px;"">
                    <div class=""input-group-append"">
                        <button type=""submit"" class=""btn btn-primary"">
                            <i class=""fas fa-cart-plus""></i>Add to Cart                                
                        </button>
                    </div>
                </div>     
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </h6>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-10 p-5\">\r\n        <h5>");
#nullable restore
#line 38 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
       Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Book Description</h5>\r\n        <p class=\"p-3\">");
#nullable restore
#line 39 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                  Write(Html.Raw(Model.Book.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <ul class=\"list p-4\">\r\n    <h5 >");
#nullable restore
#line 44 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
    Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Book Details</h5>\r\n    <br>\r\n    <li class=\"list-item d-flex justify-content-between align-items-center\">\r\n        <h5> Book Name : </h5> \r\n        <span");
            BeginWriteAttribute("class", " class=\"", 2252, "\"", 2260, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                  Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n    <hr>\r\n    <li class=\"list-item d-flex justify-content-between align-items-center\">\r\n        <h5>Barcode Number :</h5>\r\n        <span");
            BeginWriteAttribute("class", " class=\"", 2434, "\"", 2442, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                  Write(Model.Book.BarcodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n    <hr>\r\n    <li class=\"list-item d-flex justify-content-between align-items-center\">\r\n        <h5>Page Count :</h5> \r\n        <span");
            BeginWriteAttribute("class", " class=\"", 2622, "\"", 2630, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                  Write(Model.Book.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n    <hr>\r\n    <li class=\"list-item d-flex justify-content-between align-items-center\">\r\n        <h5>First Print Date :</h5> \r\n        <span");
            BeginWriteAttribute("class", " class=\"", 2812, "\"", 2820, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Shop\Details.cshtml"
                  Write(Model.Book.FirstPrintDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n    <hr>\r\n    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
