#pragma checksum "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Home\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f438f51847aba563158491c8c2e0ef2cef0c1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Content), @"mvc.1.0.view", @"/Views/Home/Content.cshtml")]
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
#line 1 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f438f51847aba563158491c8c2e0ef2cef0c1e1", @"/Views/Home/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6b7aff87533dc461051721b7bca3f8cb1a3713", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;font-size:0.7vw;font-style:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div style=""height:2vw;""></div>
<table>
    <tbody>
        <tr>    
            <td>
                <h5><b style=""color:#555555"">Sidor Arkiv</b></h5>
            </td>
            <td style=""padding-left:2vw;height:2vw;"">
                <div style=""height: 1.4vw; width: 4vw;background-color:#0293fc;text-align:center;border-radius:8%;"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f438f51847aba563158491c8c2e0ef2cef0c1e14169", async() => {
                WriteLiteral("+ Ny Sida");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </td>
        </tr>

    </tbody>
</table>
<div style=""height:0.8vw;""></div>
<table class=""table d-table w-100""  >
    <tbody>
        <tr style=""background-color:#f4f4f4;"">
            <td>
                <b>Sidans Rubrik</b>
            </td>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 915, "\"", 922, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1127, "\"", 1134, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr style=\"background-color:#f4f4f4;\">\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1380, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1585, "\"", 1592, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr style=\"background-color:#f4f4f4;\">\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1831, "\"", 1838, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2043, "\"", 2050, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n        <tr style=\"background-color:#f4f4f4;\">\r\n            <td>\r\n                <b>Sidans Rubrik</b>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2289, "\"", 2296, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:30vw;\">Ändra</b></a>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
