#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Account\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf90aae53127f40bd38c788bbfa1c5264106c8e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditUser), @"mvc.1.0.view", @"/Views/Account/EditUser.cshtml")]
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
#line 1 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.StartPageModels.PageModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.UnderPageModels.PageModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.HeaderModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.EventsModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.Adverts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf90aae53127f40bd38c788bbfa1c5264106c8e1", @"/Views/Account/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0e37cfb151450908938d0881486e9ee9e75475", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div id=""login"">
    <div style=""height:4vw;""></div>
    <div class=""container"">
        <div id=""login-row"" class=""row justify-content-center align-items-center"">
            <div id=""login-column"" class=""col-auto"" style=""background-color:#3f4044;border:2px solid #cab290;"">
                <div id=""login-box"" class=""col-md-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf90aae53127f40bd38c788bbfa1c5264106c8e16849", async() => {
                WriteLiteral(@"
                        <div style=""height:0.5vw;""></div>
                        <div class=""row"">
                            <div class=""col-1""></div>
                            <div class=""col-10"">
                                <label style=""width: 100%;color:white;font-size:0.8vw;text-align:center;"">
                                    Ändra dina konto uppgifter
                                </label>
                            </div>
                            <div class=""col-1""></div>
                        </div>
                        <div style=""height:0.5vw;""></div>
                        <div class=""form-group"">
                            <button type=""button"" class=""btn text-white p-0 text-center""");
                BeginWriteAttribute("onclick", " onclick=\"", 1168, "\"", 1220, 3);
                WriteAttributeValue("", 1178, "location.href=\'", 1178, 15, true);
#nullable restore
#line 23 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Account\EditUser.cshtml"
WriteAttributeValue("", 1193, Url.Action("UserAccount"), 1193, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1219, "\'", 1219, 1, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"font-size: 0.6vw;width:5vw;height:1.2vw;background-color:#0293fc;\">Avbryt</button>\r\n                            <button type=\"button\" class=\"btn text-white p-0 text-center\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1401, "\"", 1450, 3);
                WriteAttributeValue("", 1411, "location.href=\'", 1411, 15, true);
#nullable restore
#line 24 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Account\EditUser.cshtml"
WriteAttributeValue("", 1426, Url.Action("EditName"), 1426, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1449, "\'", 1449, 1, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"font-size: 0.6vw;width:5vw;height:1.2vw;background-color:#0293fc;\">Användarnamn</button>\r\n                            <button type=\"button\" class=\"btn text-white p-0 text-center\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1637, "\"", 1686, 3);
                WriteAttributeValue("", 1647, "location.href=\'", 1647, 15, true);
#nullable restore
#line 25 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Account\EditUser.cshtml"
WriteAttributeValue("", 1662, Url.Action("EditPass"), 1662, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1685, "\'", 1685, 1, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"font-size: 0.6vw;width:5vw;height:1.2vw;background-color:#0293fc;\">Lösenord</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Account\EditUser.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
