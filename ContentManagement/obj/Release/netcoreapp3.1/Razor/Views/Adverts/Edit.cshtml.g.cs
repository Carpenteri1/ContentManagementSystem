#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4e2f33ef482226be8a34792d8e9546d9ca78bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adverts_Edit), @"mvc.1.0.view", @"/Views/Adverts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4e2f33ef482226be8a34792d8e9546d9ca78bc", @"/Views/Adverts/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2035810ca1a686db96ecd322e943ae5313eb8479", @"/Views/_ViewImports.cshtml")]
    public class Views_Adverts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvertsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:0.5vw;height:1.2vw;width:10.5vw;background-color:white;border:1px solid lightgray;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
  
    ViewData["Title"] = Model.LinkTitle;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-7\">\n            <div class=\"container text-center align-content-center\">\n");
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                 using (Html.BeginForm("Edit", "Adverts", FormMethod.Post,
             new { enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"height:0.8vw;\"></div>\n                    <div class=\"row p-0\">\n                        <h4>Redigera annons ");
#nullable restore
#line 15 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                                       Write(Model.LinkTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    </div>
                    <hr />
                    <div class=""p-2 mw-100 mh-100"">
                        <div class=""form-group p-0 text-left"" style=""font-size:0.4vw;"">
                            <div class=""row"">
                                <div class=""col-6"">
                                    <label class=""d-block"" style=""font-size:0.5vw;font-weight:bold;"">Rubrik</label>
                                    ");
#nullable restore
#line 23 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    ");
#nullable restore
#line 24 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                               Write(Html.EditorFor(model => model.LinkTitle, new { HtmlAttributes = new { @class = "form-control", style = "font-size:0.5vw;height:1.2vw;width:10vw;background-color:white;border:1px solid lightgray;" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n                                <div class=\"col-6\">\n                                    <label class=\"d-block\" style=\"font-size:0.5vw;font-weight:bold;\">Länkar till: </label>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7a4e2f33ef482226be8a34792d8e9546d9ca78bc8999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 28 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkTo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a4e2f33ef482226be8a34792d8e9546d9ca78bc10654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 29 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkTo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""form-group p-0 "">
                            <div class=""row text-left"">
                                <div class=""col-6 "">
                                    <label>
                                        <b style=""font-size: 0.5vw;"" class=""d-block"">Annonsen aktiv:</b>  ");
#nullable restore
#line 37 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                                                                                                     Write(Html.CheckBoxFor(m => m.isActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </label>
                                </div>
                                <div class=""col-6"">
                                    <label style="" width: 100%;"">
                                        <b class=""d-block"" style=""font-size:0.5vw;margin-top:0.2vw;"">Välj reklam typ:</b>
                                        ");
#nullable restore
#line 43 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                                   Write(Html.DropDownList("selecterDropDownValue", (SelectList)ViewData["TypeOfAd"], new { style = "width:3.8vw;height:1vw;font-size:0.5vw;", @onchange = "submitform();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div style=""height:1.5vw;""></div>
                        <div class=""form-group"" style=""text-align:left;font-size:0.5vw;"">
                            <label class=""d-block"" style=""font-size:0.5vw;""><b>Splash bild</b></label>
                            ");
#nullable restore
#line 51 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.ImgUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <img class=\"d-block\"");
            BeginWriteAttribute("src", " src=", 3276, "", 3324, 1);
#nullable restore
#line 52 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
WriteAttributeValue("", 3281, Html.DisplayTextFor(model => model.ImgUrl), 3281, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"bilden kunde ej laddas\" width=\"140\" height=\"80\" />\n                            ");
#nullable restore
#line 53 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.File));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 54 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
                       Write(Html.EditorFor(model => model.File));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div style=""height:2.5vw;""></div>
                    <hr />
                    <div class=""row"">
                        <div class=""col-6 text-left"">
                            <button type=""button"" class=""btn text-white p-0 text-center""");
            BeginWriteAttribute("onclick", " onclick=\"", 3830, "\"", 3887, 3);
            WriteAttributeValue("", 3840, "location.href=\'", 3840, 15, true);
#nullable restore
#line 61 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"
WriteAttributeValue("", 3855, Url.Action("Index", "Adverts"), 3855, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3886, "\'", 3886, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#8c8c8c;"">Avbryt</button>
                        </div>
                        <div class=""col-6 text-right"">
                            <button type=""submit"" class=""btn text-white p-0 text-center"" style=""font-size: 0.4vw;width:3.8vw;height:1.2vw;background-color:#0293fc;"">Bekräfta</button>
                        </div>
                    </div>
                    <div style=""height:2.5vw;""></div>
");
#nullable restore
#line 68 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\Adverts\Edit.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"col-auto\"></div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvertsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
