#pragma checksum "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Home\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89c554c6cad445f9c3742a9f88c18f80464c8e8"
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
#nullable restore
#line 3 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.ContentManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89c554c6cad445f9c3742a9f88c18f80464c8e8", @"/Views/Home/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7581fc12321dc09c90c29b50cab499b5c815977c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container"">
    <div style=""height:2vw;""></div>
    <table>
        <tbody>
            <tr>
                <td>
                    <h6><b style=""color:#555555"">Sidor arkiv</b></h6>
                <td>
                <td style=""padding-left:2vw;"">
                    <div style=""height: 1.2vw; width: 3.5vw;background-color:#0293fc;text-align:center;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e89c554c6cad445f9c3742a9f88c18f80464c8e84403", async() => {
                WriteLiteral("<p style=\"font-size: 0.6vw;margin-bottom:0.5vw;\" class=\"text-white\">+ Ny Sida</p>");
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
    <div style=""height:0.4vw;""></div>
    <table class=""table"">
        <tbody>
            <tr style=""background-color:#f4f4f4;border-top:2px solid #b7b7b7;line-height:0.5vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1138, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b style=""margin-left:28vw;font-size:0.6vw;"">Ändra</b></a>
                </td>
            </tr>
            <tr style=""background-color:#ffffff;line-height:0.2vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1489, "\"", 1496, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b style=""margin-left:28vw;font-size:0.6vw;"">Ändra</b></a>
                </td>
            </tr>
            <tr style=""background-color:#f4f4f4;line-height:0.2vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1847, "\"", 1854, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b style=""margin-left:28vw;font-size:0.6vw;"">Ändra</b></a>
                </td>
            </tr>
            <tr style=""background-color:#ffffff;line-height:0.2vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2205, "\"", 2212, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b style=""margin-left:28vw;font-size:0.6vw;"">Ändra</b></a>
                </td>
            </tr>
            <tr style=""background-color:#f4f4f4;line-height:0.2vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2563, "\"", 2570, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b style=""margin-left:28vw;font-size:0.6vw;"">Ändra</b></a>
                </td>
            </tr>
            <tr style=""background-color:#ffffff;line-height:0.2vw;"">
                <td>
                    <a style=""font-size:0.6vw;color:#515151;""><b>Sidans Rubrik</b></a>
                </td>
                <td>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2921, "\"", 2928, 0);
            EndWriteAttribute();
            WriteLiteral("><b style=\"margin-left:28vw;font-size:0.6vw;\">Ändra</b></a>\r\n                </td>\r\n            </tr>\r\n  \r\n        </tbody>\r\n    </table>\r\n</div>");
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
