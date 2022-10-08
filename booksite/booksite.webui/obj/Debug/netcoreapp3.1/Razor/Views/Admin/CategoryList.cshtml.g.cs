#pragma checksum "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8b99436072fb28ffe5151be663ca43ae3cb03d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8b99436072fb28ffe5151be663ca43ae3cb03d", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8b6ea04b22e9d06f2cd52011d1b232c0e1e52", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletecategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Admin Categories</h1>
        <hr>
        <a class=""btn btn-primary"" href=""/admin/categories/create"">Add Category</a>
        <table class=""table table-bordered mt-3"">
            <thead class=""bg-secondary"">
                <tr>
                    <td style=""width:30px;"">Id</td>
                    <td style=""width:400px;"">Name</td>
                    <td style=""width:140px;"">Action</td>
                </tr>
            </thead>
            <tbody class=""bg-light"">
");
#nullable restore
#line 16 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                 if(Model.Categories.Count>0)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                 foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                       Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 916, "\"", 957, 2);
            WriteAttributeValue("", 923, "/admin/categories/", 923, 18, true);
#nullable restore
#line 24 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 941, item.CategoryId, 941, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8b99436072fb28ffe5151be663ca43ae3cb03d7321", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 1187, "\"", 1211, 1);
#nullable restore
#line 26 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1195, item.CategoryId, 1195, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1264, "\"", 1335, 10);
                WriteAttributeValue("", 1274, "return", 1274, 6, true);
                WriteAttributeValue(" ", 1280, "confirm(\'", 1281, 10, true);
#nullable restore
#line 27 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1290, item.Name, 1290, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1300, "Are", 1301, 4, true);
                WriteAttributeValue(" ", 1304, "you", 1305, 4, true);
                WriteAttributeValue(" ", 1308, "sure", 1309, 5, true);
                WriteAttributeValue(" ", 1313, "you", 1314, 4, true);
                WriteAttributeValue(" ", 1317, "want", 1318, 5, true);
                WriteAttributeValue(" ", 1322, "to", 1323, 3, true);
                WriteAttributeValue(" ", 1325, "delete?\')", 1326, 10, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr> \r\n");
#nullable restore
#line 31 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Categories</h3>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Ömer Göçlü\Desktop\booksite\booksite.webui\Views\Admin\CategoryList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
