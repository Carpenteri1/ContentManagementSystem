#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634dda9c25b432e5fc269fc4af972a3025ff4628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DeleteEvent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DeleteEvent/Default.cshtml")]
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
using ContentManagement.Models.FileModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634dda9c25b432e5fc269fc4af972a3025ff4628", @"/Views/Shared/Components/DeleteEvent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2276f95a2448b58a6f5584714e2509092364520e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DeleteEvent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml"
 using (Html.BeginForm("Delete", "Events", FormMethod.Post,
      new { name = "deleteEvent", id = "deleteEvent" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal-content p-2\">\r\n    ");
#nullable restore
#line 9 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"modal-title\"><h6>Tabort ");
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml"
                                   Write(Model.EventTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6></div>
        <br />
    <p style=""font-size:1.2em;"">Är du säker på att du vill ta bort sidan? Detta går inte att ångra.</p>
    <div class=""modal-footer"" style=""border:none;"">
        <div class=""col-6"">
            <button type=""button"" class=""btn text-white p-0 text-center""");
            BeginWriteAttribute("onclick", " onclick=\"", 565, "\"", 621, 3);
            WriteAttributeValue("", 575, "location.href=\'", 575, 15, true);
#nullable restore
#line 15 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml"
WriteAttributeValue("", 590, Url.Action("Index", "Events"), 590, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 620, "\'", 620, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#8c8c8c;"">Avbryt</button>
        </div>
        <div class=""col-6"">
            <button type=""submit"" class=""btn text-white p-0 text-center"" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#cc0000;"">Ta bort</button>
        </div>
    </div>
</div>
");
#nullable restore
#line 22 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Shared\Components\DeleteEvent\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    function submitform() {\r\n        $(\'#deleteEvent\').submit();\r\n    }\r\n</script>\r\n");
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
