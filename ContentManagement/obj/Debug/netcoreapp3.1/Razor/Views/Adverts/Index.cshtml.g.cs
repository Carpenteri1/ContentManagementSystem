#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6903f87d99ec978c1a4af24bab24d046d0336e8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6903f87d99ec978c1a4af24bab24d046d0336e8", @"/Views/Adverts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acaf67ee4ce0b135a87aa9904fe83f3ab311542", @"/Views/_ViewImports.cshtml")]
    public class Views_Adverts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white p-0 text-center shader form-control center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 0.4vw;width:3vw;height:1vw;background-color:#0293fc;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
  
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
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6903f87d99ec978c1a4af24bab24d046d0336e87147", async() => {
                WriteLiteral("Nytt Event +");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
#line 30 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
             if (Model.Count() <= 0 ||
            Model == null)
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
#line 38 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                 for (int i = 0; i < Model.Count(); i++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"line-height:0.2vw;\">\r\n");
#nullable restore
#line 45 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                         if (i % 2 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"font-size:0.5vw;background-color:#d0c8c8;font-weight:bold;\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <td style=""background-color:#d0c8c8;"">
                                <a>
                                    <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">
                                        ");
#nullable restore
#line 53 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                                   Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </b>\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 57 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"font-size:0.5vw;background-color:white;font-weight:bold;\">\r\n                                ");
#nullable restore
#line 61 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => Model[i].EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <td style=""background-color:white"">
                                <a>
                                    <b style=""text-align: right; width:100%;  display: inline-block;font-size:0.5vw;"">
                                        ");
#nullable restore
#line 66 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                                   Write(Html.ActionLink("Ändra", "Edit", new { id = Model[i].Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </b>\r\n                                </a>\r\n                            </td>\r\n");
#nullable restore
#line 70 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 73 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagement\ContentManagement\Views\Adverts\Index.cshtml"
                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
