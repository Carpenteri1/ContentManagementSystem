#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e437ce5135604b97108c8ab9336a3e2a86ced225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Delete), @"mvc.1.0.view", @"/Views/Events/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e437ce5135604b97108c8ab9336a3e2a86ced225", @"/Views/Events/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acaf67ee4ce0b135a87aa9904fe83f3ab311542", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentManagement.Models.EventsModel.EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-7\">\r\n            <div style=\"height:1.5vw;\"></div>\r\n            <h4>Vill du tabort eventet ");
#nullable restore
#line 13 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                                  Write(Model.EventTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <hr />\r\n            <div>\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.EventTextContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.EventTextContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Edited));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Edited));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 35 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                     foreach (var s in Model.Links)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => s.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                       Write(Html.DisplayFor(model => s.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => s.LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 47 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                       Write(Html.DisplayFor(model => s.LinkTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 49 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.EventStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.EventStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.EventEnds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.EventEnds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <div style=\"height:1.5vw;\"> </div>\r\n                <hr />\r\n");
#nullable restore
#line 65 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                 using (Html.BeginForm("Delete", "Events", FormMethod.Post,
               new { enctype = "multipart/form-data" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
               Write(Html.HiddenFor(model => model.Links[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\">\r\n                                <button type=\"button\" class=\"btn text-white p-0 text-center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3113, "\"", 3169, 3);
            WriteAttributeValue("", 3123, "location.href=\'", 3123, 15, true);
#nullable restore
#line 73 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
WriteAttributeValue("", 3138, Url.Action("Index", "Events"), 3138, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3168, "\'", 3168, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#8c8c8c;"">Avbryt</button>
                            </div>
                            <div class=""col-6 text-right"">
                                <button type=""submit"" class=""btn text-white p-0 text-center"" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#cc0000;"">Tabort</button>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 80 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Events\Delete.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-auto\"></div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentManagement.Models.EventsModel.EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591