#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d977b6bf767c45dd3204605efc16c7946f99e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d977b6bf767c45dd3204605efc16c7946f99e1", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0e37cfb151450908938d0881486e9ee9e75475", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div style=""height:1.5vw;""></div>
<div class=""centered-div mw-100 mh-100"" style=""border-bottom:2px solid black;"">
    <div class=""row"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-6"">
                    <label style="" width: 100%; text-align: left; display: inline-block;"">
                        <b style=""color:#555555;font-size:0.8vw;"">Event arkiv</b>
                        <button type=""button"" class=""btn text-white p-0 text-center form-control""");
            BeginWriteAttribute("onclick", " onclick=\"", 599, "\"", 656, 3);
            WriteAttributeValue("", 609, "location.href=\'", 609, 15, true);
#nullable restore
#line 17 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 624, Url.Action("Create", "Events"), 624, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 655, "\'", 655, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3vw;height:1vw;background-color:#0293fc;"">Nytt Event +</button>
                    </label>
                </div>
                <div class=""col-6"">
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""centered-div mw-100 mh-100"">
    <table class=""table"" style=""line-height:0.2vw;"">
        <tbody>

");
#nullable restore
#line 32 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"line-height:0.2vw;\">\r\n");
#nullable restore
#line 37 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                 if (i % 2 == 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                     if (Model[i].Applicants != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            ");
#nullable restore
#line 43 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n                            Anmälningar &nbsp; - &nbsp;(<span style=\"color: mediumseagreen;\">");
#nullable restore
#line 46 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                        Write(Model[i].Applicants.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>) &nbsp; - &nbsp; <a>");
#nullable restore
#line 46 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                                                                                Write(Html.ActionLink("Visa", "Applicants", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n");
#nullable restore
#line 48 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            ");
#nullable restore
#line 53 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            Anmälningar &nbsp; - &nbsp;(<span style=\"color:red;\">0</span>)  &nbsp; - &nbsp; <a>");
#nullable restore
#line 57 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                                          Write(Html.ActionLink("Visa", "Applicants", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n");
#nullable restore
#line 59 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color: #f4f4f4;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n\r\n                        <a class=\"d-block\">");
#nullable restore
#line 62 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                      Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2884, "\"", 2958, 2);
            WriteAttributeValue("", 2891, "#", 2891, 1, true);
#nullable restore
#line 63 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 2892, Html.DisplayTextFor(model => model[i].EventTitle).Replace(" ",""), 2892, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 3163, "\"", 3234, 1);
#nullable restore
#line 64 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 3168, Html.DisplayTextFor(model => model[i].EventTitle).Replace(" ",""), 3168, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                            <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                           Write(await Component.InvokeAsync("DeleteEvent", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n");
#nullable restore
#line 70 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                     if (Model[i].Applicants != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            ");
#nullable restore
#line 77 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            Anmälningar &nbsp; - &nbsp;(<span style=\"color: mediumseagreen;\">");
#nullable restore
#line 81 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                        Write(Model[i].Applicants.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>)  &nbsp; - &nbsp; <a>");
#nullable restore
#line 81 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                                                                                 Write(Html.ActionLink("Visa", "Applicants", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n");
#nullable restore
#line 83 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            ");
#nullable restore
#line 88 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n\r\n                            Anmälningar &nbsp; - &nbsp;(<span style=\"color:red;\">0</span>)  &nbsp; - &nbsp; <a>");
#nullable restore
#line 92 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                                                                                          Write(Html.ActionLink("Visa", "Applicants", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n");
#nullable restore
#line 94 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color: white;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                        <a class=\"d-block\">");
#nullable restore
#line 96 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                                      Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5241, "\"", 5315, 2);
            WriteAttributeValue("", 5248, "#", 5248, 1, true);
#nullable restore
#line 97 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 5249, Html.DisplayTextFor(model => model[i].EventTitle).Replace(" ",""), 5249, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 5520, "\"", 5591, 1);
#nullable restore
#line 98 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 5525, Html.DisplayTextFor(model => model[i].EventTitle).Replace(" ",""), 5525, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                            <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">\r\n                                ");
#nullable restore
#line 100 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                           Write(await Component.InvokeAsync("DeleteEvent", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n");
#nullable restore
#line 104 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 106 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr style=""background-color:#f4f4f4;"">
                    <td>
                        <a style=""text-align: left;width:10vw;display:inline-block; font-size: 0.5vw; color: #515151;""><b> Inga sidor tillgängliga</b></a>
                    </td>
                </tr>
");
#nullable restore
#line 115 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script type=""text/javascript"">
    $(function () {
        $('.modal').click(function () {
            $('<div/>').appendTo('body').dialog({
                close: function (event, ui) {
                    dialog.remove();
                },
                modal: true
            }).load(this.href, {});
            return false;
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
