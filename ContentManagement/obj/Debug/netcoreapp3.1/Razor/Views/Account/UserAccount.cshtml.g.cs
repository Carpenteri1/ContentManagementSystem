#pragma checksum "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab0df25bf1a9bf78cfed9e75ca65fdca54ddd7b"
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
#nullable restore
#line 4 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\_ViewImports.cshtml"
using ContentManagement.Models.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab0df25bf1a9bf78cfed9e75ca65fdca54ddd7b", @"/Views/Account/UserAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318be6cb39ed8637ce6022cb6123b618dc2c11fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div style=""height:2vw;""></div>
<div class=""row"">
    <div class=""col""></div>
    <div class=""col"">
        <div class=""container"">
            <div style="" border: 2px solid #bbad93; padding: 20px; width: 300px;background-color:#3f4044;"">
                <h5 class=""text-white text-left"">Kontouppgifter</h5>
                <p class=""text-white text-left"">
                    Användare: ");
#nullable restore
#line 11 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
                    Konto typ: (placeholder) admin
                </p>
                <div style=""height:0.5vw;""></div>
                <div style=""list-style:none;font-size:0.6vw;border-top:1px solid #bbad93;height:0.5vw;"">
                    <div style=""height:1vw;""></div>
                    <div class=""float-left"">
                        <button type=""button"" class=""btn text-white p-0 text-center """);
            BeginWriteAttribute("onclick", " onclick=\"", 855, "\"", 904, 3);
            WriteAttributeValue("", 865, "location.href=\'", 865, 15, true);
#nullable restore
#line 18 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
WriteAttributeValue("", 880, Url.Action("Register"), 880, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 903, "\'", 903, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 0.4vw;width:2.8vw;height:1.2vw;background-color:#0293fc;\">Ny användare</button>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1057, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <button type=\"button\" class=\"btn text-white p-0 text-center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1153, "\"", 1198, 3);
            WriteAttributeValue("", 1163, "location.href=\'", 1163, 15, true);
#nullable restore
#line 21 "C:\Users\nicla\source\repos\ContentManagement\ContentManagement\Views\Account\UserAccount.cshtml"
WriteAttributeValue("", 1178, Url.Action("Edit"), 1178, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1197, "\'", 1197, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:2.8vw;height:1.2vw;background-color:#0293fc;"">Ändra konto</button>
                    </div>
                    <div style=""height:1vw;""></div>
                </div>
                <div style=""height:2vw;""></div>
            </div>
        </div>
    </div>
    <div class=""col""></div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
