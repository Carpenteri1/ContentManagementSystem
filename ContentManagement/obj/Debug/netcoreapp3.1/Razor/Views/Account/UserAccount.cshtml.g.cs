#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d25932eca366484c919c79e86c8653b450efe7de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserAccount), @"mvc.1.0.view", @"/Views/Account/UserAccount.cshtml")]
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
#line 1 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.StartPageModels.PageModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.UnderPageModels.PageModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.HeaderModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.EventsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d25932eca366484c919c79e86c8653b450efe7de", @"/Views/Account/UserAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acaf67ee4ce0b135a87aa9904fe83f3ab311542", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 0.5vw;width:5vw;height:1.2vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container"">
    <div style=""height:1.5vw;""></div>
    <div class=""centered-div mw-100 mh-100"" style=""border-bottom:2px solid black;"">
        <div class=""row"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6"">
                        <label style="" width: 100%; text-align: left; display: inline-block;"">
                            <b style=""color:#555555;font-size:0.8vw;"">Kontouppgifter:</b>
                        </label>
                    </div>
                    <div class=""col-6"">
");
#nullable restore
#line 15 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                         if(ViewData["error"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 17 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                          Write(ViewData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\r\n");
#nullable restore
#line 18 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label style=\" width: 100%; text-align: right; display: inline-block;\">\r\n");
#nullable restore
#line 20 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                             if (User.IsInRole(UserRoles.Admin.ToString()))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn text-white p-0 text-center \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1065, "\"", 1114, 3);
            WriteAttributeValue("", 1075, "location.href=\'", 1075, 15, true);
#nullable restore
#line 22 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
WriteAttributeValue("", 1090, Url.Action("Register"), 1090, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1113, "\'", 1113, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 0.6vw;width:5vw;height:1.2vw;background-color:#0293fc;\">Ny användare +</button>\r\n");
#nullable restore
#line 23 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!--List-->\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
             foreach (var s in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                 if (s.UserName.Equals(User.Identity.Name))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr style=""background-color:#f4f4f4;line-height:0.2vw;"">
                        <td>
                            <b style=""text-align: left;width:10vw;display: inline-block; font-size: 0.5vw; color: #515151;"">Användarnamn: </b>
                        </td>
                        <td>
                            <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">");
#nullable restore
#line 42 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                         Write(s.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                        </td>
                    </tr>
                    <tr style=""background-color:white;line-height:0.2vw;"">
                        <td>
                            <b style=""text-align: left;width:10vw;display: inline-block; font-size: 0.5vw; color: #515151;"">Kontotyp: </b>
                        </td>
                        <td>
                            <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">");
#nullable restore
#line 50 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                         Write(s.UserRole);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                        </td>
                    </tr>
                    <tr style=""background-color:#f4f4f4;line-height:0.2vw;"">
                        <td>
                            <b style=""text-align: left;width:10vw;display: inline-block; font-size: 0.5vw; color: #515151;"">Namn: </b>
                        </td>
                        <td>
                            <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">");
#nullable restore
#line 58 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                         Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 58 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                                        Write(s.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                        </td>
                    </tr>
                    <tr style=""background-color:white;line-height:0.2vw;"">
                        <td>
                            <b style=""text-align: left;width:10vw;display: inline-block; font-size: 0.5vw; color: #515151;"">Skapad: </b>
                        </td>
                        <td>
                            <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">");
#nullable restore
#line 66 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                         Write(s.UserCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                        </td>
                    </tr>
                    <tr style=""background-color:#f4f4f4;line-height:0.2vw;"">
                        <td>
                            <b style=""text-align: left;width:10vw;display: inline-block; font-size: 0.5vw; color: #515151;"">Senast inloggad: </b>
                        </td>
                        <td>
                            <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">");
#nullable restore
#line 74 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                                                                                                         Write(s.LastLoggedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                     if (User.IsInRole(UserRoles.Admin.ToString()))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr style=\"background-color:white;line-height:0.2vw;\">\r\n                            <td>\r\n                            </td>\r\n                            <td style=\"text-align:right;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d25932eca366484c919c79e86c8653b450efe7de14827", async() => {
                WriteLiteral("<b>Ändra uppgifter</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 87 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
