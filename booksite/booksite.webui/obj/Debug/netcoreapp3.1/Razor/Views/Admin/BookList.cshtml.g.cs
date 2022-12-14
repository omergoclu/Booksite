#pragma checksum "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a4bdf48357665d80ab6615c14b71953eda116e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BookList), @"mvc.1.0.view", @"/Views/Admin/BookList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a4bdf48357665d80ab6615c14b71953eda116e", @"/Views/Admin/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8b6ea04b22e9d06f2cd52011d1b232c0e1e52", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.12.1/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.12.1/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready( function () {
            $('#myTable').DataTable();
        });
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
            <h1 class=""h3"">Admin Books</h1>
        <hr>
        
        <a class=""btn btn-primary mb-2"" href=""/admin/books/create"">Add Book </a> 
        <table  data-page-length='5' id=""myTable""  class=""table table-bordered mt-3"">
            <thead class=""bg-secondary"">
                <tr>
                    <td style=""width:30px;"">Id</td>
                    <td style=""width:100px;"">Image</td>
                    <td style=""width:30px;"">Book Name</td>
                    <td style=""width:30px;"">Price</td>
                    <td style=""width:30px;"">Barcode Number</td>
                    <td style=""width:30px;"">Page Count</td>
                    <td style=""width:30px;"">FirstPrintDate</td>
                    <td style=""width:30px;"">Author</td>
                    <td style=""width:30px;"">Publisher</td>
                    <td style=""width:30px;"">IsHome</td>
                    <td style=""width:30px;"">IsApproved</td>
                    <");
            WriteLiteral("td style=\"width:190px;\">Action</td>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"bg-light\">\r\n");
#nullable restore
#line 41 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                 if(Model.Books.Count>0)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                 foreach (var item in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8a4bdf48357665d80ab6615c14b71953eda116e8268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1872, "~/img/", 1872, 6, true);
#nullable restore
#line 47 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
AddHtmlAttributeValue("", 1878, item.ImageUrl, 1878, 14, false);

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
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.BarcodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                       Write(item.FirstPrintDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 54 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                             if (Model.Authors.FirstOrDefault(x => x.AuthorId == item.AuthorId) != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                           Write(Model.Authors.FirstOrDefault(x => x.AuthorId == item.AuthorId).NameLastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                                                                                                            
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            (");
#nullable restore
#line 58 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                        Write(item.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                            </td>\r\n                        <td>\r\n");
#nullable restore
#line 61 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                             if (Model.Publishers.FirstOrDefault(x => x.PublisherId == item.PublisherId) != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                           Write(Model.Publishers.FirstOrDefault(x => x.PublisherId == item.PublisherId).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                                                                                                             
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            (");
#nullable restore
#line 65 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                        Write(item.PublisherId);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 68 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                             if(item.IsHome){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-circle-check\"></i>\r\n");
#nullable restore
#line 70 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-circle-xmark\"></i>\r\n");
#nullable restore
#line 73 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 76 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                             if(item.IsApproved){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-circle-check\"></i>\r\n");
#nullable restore
#line 78 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-circle-xmark\"></i>\r\n");
#nullable restore
#line 81 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3719, "\"", 3751, 2);
            WriteAttributeValue("", 3726, "/admin/books/", 3726, 13, true);
#nullable restore
#line 84 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
WriteAttributeValue("", 3739, item.BookId, 3739, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a4bdf48357665d80ab6615c14b71953eda116e16253", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 3973, "\"", 3993, 1);
#nullable restore
#line 86 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
WriteAttributeValue("", 3981, item.BookId, 3981, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" onclick=\"return confirm(\'Are you sure you want to delete?\')\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr> \r\n");
#nullable restore
#line 91 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Books</h3>\r\n                    </div>\r\n");
#nullable restore
#line 98 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\BookList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
