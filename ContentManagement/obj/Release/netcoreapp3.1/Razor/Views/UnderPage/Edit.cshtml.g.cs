#pragma checksum "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34def3bf84d85887dca11cfc3df3cbe77b80f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UnderPage_Edit), @"mvc.1.0.view", @"/Views/UnderPage/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34def3bf84d85887dca11cfc3df3cbe77b80f3e", @"/Views/UnderPage/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d99f729d15ad1eb5830da23fce3868d7cb8054", @"/Views/_ViewImports.cshtml")]
    public class Views_UnderPage_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnderPage>
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
#line 2 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
  
    ViewData["Title"] = Model.LinkTitle;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-7\">\r\n            <div class=\"container text-center align-content-center\">\r\n");
#nullable restore
#line 10 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                 using (Html.BeginForm("Edit", "UnderPage", FormMethod.Post,
             new { enctype = "multipart/form-data" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"height:0.8vw;\"></div>\r\n                    <div class=\"row p-0\">\r\n                        <h4>Redigera undersida ");
#nullable restore
#line 15 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                                          Write(ViewData["Title"]);

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
                                    <label class=""d-block"" style=""font-size:0.5vw;""><b>Rubrik:</b></label>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a34def3bf84d85887dca11cfc3df3cbe77b80f3e8436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 23 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PageTitle);

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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34def3bf84d85887dca11cfc3df3cbe77b80f3e10096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 24 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PageTitle);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <label class=\"d-block\" style=\"font-size:0.5vw;\"><b>Länktext i meny:</b></label>\r\n                                    ");
#nullable restore
#line 28 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                               Write(Html.EditorFor(model => model.LinkTitle, new { HtmlAttributes = new { @class = "form-control", style = "font-size:0.5vw;height:1.2vw;width:10vw;background-color:white;border:1px solid lightgray;" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group p-0 text-left\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.HeaderContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <label style=\" width: 100%;\">\r\n                                <b class=\"d-block\" style=\"font-size:0.5vw;margin-top:0.2vw;\">Välj undermeny:</b>\r\n                                ");
#nullable restore
#line 37 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                           Write(Html.DropDownList("selecterDropDownValue", (SelectList)ViewData["HeaderTheme"], new { style = "width:3.8vw;height:1vw;font-size:0.5vw;left-left;", @onchange = "submitform();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </div>
                    </div>
                        <div style=""height:1.5vw;""></div>
                        <div class=""form-group"" style=""text-align:left;font-size:0.5vw;"">
                            <label class=""d-block"" style=""font-size:0.5vw;""><b>Splash bild</b></label>
                            ");
#nullable restore
#line 44 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.TopImage.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <img class=\"d-block\"");
            BeginWriteAttribute("src", " src=", 2919, "", 2976, 1);
#nullable restore
#line 45 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
WriteAttributeValue("", 2924, Html.DisplayTextFor(model => model.TopImage.ImgSrc), 2924, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"240\" height=\"140\" style=\"border:1px solid gray;\" />\r\n                            ");
#nullable restore
#line 46 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.HiddenFor(model => model.TopImage.File));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.EditorFor(model => model.TopImage.File));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div style=""height:3vw;""></div>
                        <div class=""form-group text-left"" style=""font-size:0.5vw;"">
                            <label class=""control-label text-left"" style=""font-weight:bold;"">Brödtext: </label>
                            ");
#nullable restore
#line 52 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.HiddenFor(text => text.TextContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 53 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.TextContent, new { id = "editor2", style = "text-align:left;font-size:0.5vw;height:30vw;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    <div style=""height:2.5vw;""></div>
                    <h6 class=""text-left"">Metainformation</h6>
                    <hr />
                    <div class=""form-group p-0 text-left"">
                        <div class=""row"">
                            <div style=""height:1vw;""></div>
                            <b style=""font-size: 0.5vw;"" class=""pl-3 pr-1"">Publik:</b>  ");
#nullable restore
#line 61 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                                                                                   Write(Html.CheckBoxFor(m => m.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b style=\"font-size: 0.5vw;\" class=\"pl-3 pr-1\">Visa eventlista:</b>  ");
#nullable restore
#line 62 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                                                                                            Write(Html.CheckBoxFor(m => m.ShowEventModul));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b style=\"font-size: 0.5vw;\" class=\"pl-3 pr-1\">Visa kontaktformulär:</b>  ");
#nullable restore
#line 63 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                                                                                                 Write(Html.CheckBoxFor(m => m.ShowFormModul));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <b style=\"font-size: 0.5vw;\" class=\"pl-3 pr-1\">Visa Anmälningsformulär:</b>  ");
#nullable restore
#line 64 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
                                                                                                    Write(Html.CheckBoxFor(m => m.ShowEmailFormModul));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <hr />
                    <div class=""row"">
                        <div class=""col-6 text-left"">
                            <button type=""button"" class=""btn text-white p-0 text-center""");
            BeginWriteAttribute("onclick", " onclick=\"", 4870, "\"", 4929, 3);
            WriteAttributeValue("", 4880, "location.href=\'", 4880, 15, true);
#nullable restore
#line 70 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"
WriteAttributeValue("", 4895, Url.Action("Index", "UnderPage"), 4895, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4928, "\'", 4928, 1, true);
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
#line 77 "C:\Users\nicla\source\repos\AMV\Golf\ContentManagementSystem\ContentManagement\Views\UnderPage\Edit.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-auto\"></div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnderPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
