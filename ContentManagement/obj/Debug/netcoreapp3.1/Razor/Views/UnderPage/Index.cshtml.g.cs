#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4081b3c65bd53110b0761385eb469483d8808c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UnderPage_Index), @"mvc.1.0.view", @"/Views/UnderPage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4081b3c65bd53110b0761385eb469483d8808c5b", @"/Views/UnderPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2035810ca1a686db96ecd322e943ae5313eb8479", @"/Views/_ViewImports.cshtml")]
    public class Views_UnderPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UnderPage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"height:1.5vw;\"></div>\r\n<div class=\"centered-div mw-100 mh-100\" style=\"border-bottom:2px solid black;\">\r\n    <div class=\"row\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
             using (Html.BeginForm("Index", "UnderPage", FormMethod.Post, new { name = "header", id = "header" }))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-6"">
                        <label style="" width: 100%; text-align: left; display: inline-block;"">
                            <b style=""color:#555555;font-size:0.8vw;"">Sidor arkiv</b>
                            <button type=""button"" class=""btn text-white p-0 text-center form-control""");
            BeginWriteAttribute("onclick", " onclick=\"", 745, "\"", 805, 3);
            WriteAttributeValue("", 755, "location.href=\'", 755, 15, true);
#nullable restore
#line 17 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
WriteAttributeValue("", 770, Url.Action("Create", "UnderPage"), 770, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 804, "\'", 804, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3vw;height:1vw;background-color:#0293fc;"">Ny sida +</button>
                        </label>
                    </div>

                    <div class=""col-6"">
                        <label style="" width: 100%; text-align: right; display: inline-block;"">
                            <b style=""font-size:0.5vw;margin-top:0.2vw;"">Välj huvudmeny:</b>
                            ");
#nullable restore
#line 24 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                       Write(Html.DropDownList("selecterDropDownValue", (SelectList)ViewData["HeaderTheme"], new { style = "width:3.8vw;height:1vw;font-size:0.5vw;", @onchange = "submitform();", id= "header" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"centered-div mw-100 mh-100\">\r\n    <table class=\"table\" style=\"line-height:0.2vw;\">\r\n        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"line-height:0.2vw;\">\r\n");
#nullable restore
#line 41 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                 if (i % 2 == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Model[i].LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"background-color: #f4f4f4;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                        <a class=\"d-block\">");
#nullable restore
#line 47 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                                      Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2406, "\"", 2463, 2);
            WriteAttributeValue("", 2413, "#", 2413, 1, true);
#nullable restore
#line 48 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
WriteAttributeValue("", 2414, Html.DisplayTextFor(model => model[i].pageRoute), 2414, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 2668, "\"", 2722, 1);
#nullable restore
#line 49 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
WriteAttributeValue("", 2673, Html.DisplayTextFor(model => model[i].pageRoute), 2673, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                            <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">                               \r\n                                        ");
#nullable restore
#line 51 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                                   Write(await Component.InvokeAsync("DeleteUnderPage", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n");
#nullable restore
#line 55 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Model[i].LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"background-color: white;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                        <a class=\"d-block\">");
#nullable restore
#line 63 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                                      Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3685, "\"", 3742, 2);
            WriteAttributeValue("", 3692, "#", 3692, 1, true);
#nullable restore
#line 64 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
WriteAttributeValue("", 3693, Html.DisplayTextFor(model => model[i].pageRoute), 3693, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 3947, "\"", 4001, 1);
#nullable restore
#line 65 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
WriteAttributeValue("", 3952, Html.DisplayTextFor(model => model[i].pageRoute), 3952, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                            <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">\r\n                                ");
#nullable restore
#line 67 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                           Write(await Component.InvokeAsync("DeleteUnderPage", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n");
#nullable restore
#line 71 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
                 
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
#line 83 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Index.cshtml"
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
</script>
<script>
    function submitform() {
        $('#header').submit();
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UnderPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
