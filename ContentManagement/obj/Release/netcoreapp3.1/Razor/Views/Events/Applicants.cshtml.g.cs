#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9628f47649af50d7eccde39fb07215a904d5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Applicants), @"mvc.1.0.view", @"/Views/Events/Applicants.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9628f47649af50d7eccde39fb07215a904d5de", @"/Views/Events/Applicants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0e37cfb151450908938d0881486e9ee9e75475", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Applicants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div style=""height:1.5vw;""></div>
<div class=""centered-div mw-100 mh-100"" style=""border-bottom:2px solid black;"">
    <div class=""row"">
        <div class=""container"">
            <div class=""row ml-1"">
                    <label style="" width: 100%; text-align: left; display: inline-block;"">
                        <b style=""color:#555555;font-size:0.8vw;"">");
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                                                             Write(Model.EventTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                    </label>
            </div>
        </div>
    </div>
</div>
<div class=""centered-div mw-100 mh-100"">
    <table class=""table"" style=""line-height:1em;margin-bottom:0.2em;border-bottom:2px solid black;background-color:#f4f4f4;"">
        <tbody>
            <tr style=""line-height:0.2vw;"">
                <td style=""font-size: 0.5vw; font-weight: bold;width:18.8em;""><span style=""margin-left:-0.5em;"">Namn</span></td>
                <td style=""font-size: 0.5vw; font-weight: bold;width:15em;"">GolfId</td>
                <td style=""font-size: 0.5vw; font-weight: bold;width:18em;"">Hemmaklubb</td>
                <td style=""font-size: 0.5vw; font-weight: bold;width:31.5em;"">MailAdress</td>
                <td style=""font-size: 0.5vw; font-weight: bold;width:15.5em;"">Telefon</td>
                <td style=""font-size: 0.5vw; font-weight: bold;"">Mer Info</td>
            </tr>
        </tbody>
    </table>
    <table class=""table"" style=""line-height:0.2vw;margin-top:-0.2em;"">");
            WriteLiteral("\n        <tbody>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
             if (Model != null &&
      Model.Applicants != null &&
      Model.Applicants.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                 for (int i = 0; i < Model.Applicants.Count(); i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                     if (i % 2 == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr style=\"line-height:0.2vw;\">\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 42 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                                                                 Write(Model.Applicants[i].SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 45 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].GolfId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].HomeClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 51 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 54 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                <a>");
#nullable restore
#line 57 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                              Write(Html.ActionLink("Visa", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr style=\"line-height:0.2vw;\">\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 65 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 65 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                                                                 Write(Model.Applicants[i].SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 68 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].GolfId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 71 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].HomeClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 74 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 77 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                           Write(Model.Applicants[i].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                <a>");
#nullable restore
#line 80 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                              Write(Html.ActionLink("Visa", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr style=""background-color:#f4f4f4;"">
                    <td>
                        <a style=""text-align: left;width:10vw;display:inline-block; font-size: 0.5vw; color: red;""><b> Inga deltagare anmälda</b></a>
                    </td>
                </tr>
");
#nullable restore
#line 93 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Applicants.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
