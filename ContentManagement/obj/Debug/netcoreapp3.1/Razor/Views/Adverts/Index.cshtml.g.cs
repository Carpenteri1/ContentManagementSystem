#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a826f77355ccae0ea4a611679fc524bda713f9ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adverts_Index), @"mvc.1.0.view", @"/Views/Adverts/Index.cshtml")]
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
#nullable restore
#line 11 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.FilesModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a826f77355ccae0ea4a611679fc524bda713f9ff", @"/Views/Adverts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d99f729d15ad1eb5830da23fce3868d7cb8054", @"/Views/_ViewImports.cshtml")]
    public class Views_Adverts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"height:1.5vw;\"></div>\r\n<div class=\"centered-div mw-100 mh-100\" style=\"border-bottom:2px solid black;\">\r\n    <div class=\"row\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
             using (Html.BeginForm("Index", "Adverts", FormMethod.Post, new { name = "AdvertHeader", id = "AdvertHeader" }))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-6"">
                        <label style="" width: 32%; text-align: left; display: inline-block;"">
                            <b style=""color:#555555;font-size:0.8vw;"">Annons arkiv</b>
                            <button type=""button"" class=""btn text-white p-0 text-center form-control""");
            BeginWriteAttribute("onclick", " onclick=\"", 756, "\"", 814, 3);
            WriteAttributeValue("", 766, "location.href=\'", 766, 15, true);
#nullable restore
#line 16 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
WriteAttributeValue("", 781, Url.Action("Create", "Adverts"), 781, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 813, "\'", 813, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3vw;height:1vw;background-color:#0293fc;"">Ny annons +</button>
                        </label>
                    </div>

                    <div class=""col-6"">
                        <label style="" width: 100%; text-align: right; display: inline-block;"">
                            <b style=""font-size:0.5vw;margin-top:0.2vw;"">Välj annons typ:</b>
                            ");
#nullable restore
#line 23 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                       Write(Html.DropDownList("selecterDropDownValue", (SelectList)ViewData["TypeOfAd"], new { style = "width:3.8vw;height:1vw;font-size:0.5vw;", @onchange = "submitform();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"centered-div mw-100 mh-100\">\r\n    <table class=\"table\" style=\"line-height:0.2vw;\">\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"line-height:0.2vw;\">\r\n");
#nullable restore
#line 42 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                         if (i % 2 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"font-size:0.5vw;background-color:#f4f4f4;font-weight:bold;\" class=\"p-2\">\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 46 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                           Write(Html.DisplayTextFor(model => model[i].LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: #f4f4f4;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                <a class=\"d-block\">");
#nullable restore
#line 49 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                                              Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2564, "\"", 2637, 2);
            WriteAttributeValue("", 2571, "#", 2571, 1, true);
#nullable restore
#line 50 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
WriteAttributeValue("", 2572, Html.DisplayTextFor(model => model[i].LinkTitle).Replace(" ",""), 2572, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 2850, "\"", 2920, 1);
#nullable restore
#line 51 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
WriteAttributeValue("", 2855, Html.DisplayTextFor(model => model[i].LinkTitle).Replace(" ",""), 2855, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                                    <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">\r\n                                        ");
#nullable restore
#line 53 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                                   Write(await Component.InvokeAsync("DeleteAdvert", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n");
#nullable restore
#line 57 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\" class=\"p-2\">\r\n                                ");
#nullable restore
#line 61 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"background-color: white;text-align: right; width:100%; display: inline-block;font-size:0.5vw;font-weight:bold;\" class=\"p-2\">\r\n                                <a class=\"d-block\">");
#nullable restore
#line 64 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                                              Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3951, "\"", 4024, 2);
            WriteAttributeValue("", 3958, "#", 3958, 1, true);
#nullable restore
#line 65 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
WriteAttributeValue("", 3959, Html.DisplayTextFor(model => model[i].LinkTitle).Replace(" ",""), 3959, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" id=\"ShowPopup\" data-toggle=\"modal\" class=\"text-decoration-none\" style=\"color:#cc0000;\"> <span style=\"color:black;\">-</span> &nbsp;&nbsp;&nbsp;&nbsp;Ta bort</a>\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 4237, "\"", 4307, 1);
#nullable restore
#line 66 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
WriteAttributeValue("", 4242, Html.DisplayTextFor(model => model[i].LinkTitle).Replace(" ",""), 4242, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade \" role=\"dialog\">\r\n                                    <div class=\"modal-dialog text-center\" style=\"width:35%;margin-top:10%;\">\r\n                                        ");
#nullable restore
#line 68 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                                   Write(await Component.InvokeAsync("DeleteAdvert", new { Id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </td>\r\n");
#nullable restore
#line 73 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 76 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
                 
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
#line 85 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Index.cshtml"
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
        $('#AdvertHeader').submit();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
