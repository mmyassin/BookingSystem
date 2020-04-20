#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ebce2fe6190fa0833b6a5e7b8131ff5316ea8c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__EditModal), @"mvc.1.0.view", @"/Views/Users/_EditModal.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
using BookingSystem.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
using BookingSystem.Web.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebce2fe6190fa0833b6a5e7b8131ff5316ea8c3", @"/Views/Users/_EditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__EditModal : BookingSystem.Web.Views.BookingSystemRazorPage<EditUserModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("UserEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Users/_EditModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditUser"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ebce2fe6190fa0833b6a5e7b8131ff5316ea8c35936", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 386, "\"", 408, 1);
#nullable restore
#line 10 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 394, Model.User.Id, 394, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"modal-body\">\r\n        <ul class=\"nav nav-tabs\" role=\"tablist\">\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link active\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-details\">");
#nullable restore
#line 14 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                             Write(L("UserDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-roles\">");
#nullable restore
#line 17 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                    Write(L("UserRoles"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
            </li>
        </ul>
        <div class=""tab-content mt-4"">
            <div role=""tabpanel"" class=""tab-pane container animated fadeIn active"" id=""edit-user-details"">
                <div class=""form-group row required"">
                    <label class=""col-md-3 col-form-label"" for=""username"">");
#nullable restore
#line 23 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("UserName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-9\">\r\n                        <input id=\"username\" type=\"text\" class=\"form-control\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 1286, "\"", 1314, 1);
#nullable restore
#line 25 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1294, Model.User.UserName, 1294, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1324, "\"", 1366, 1);
#nullable restore
#line 25 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1336, AbpUserBase.MaxUserNameLength, 1336, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" minlength=\"2\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row required\">\r\n                    <label class=\"col-md-3 col-form-label\" for=\"name\">");
#nullable restore
#line 29 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                 Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-9\">\r\n                        <input id=\"name\" type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1710, "\"", 1734, 1);
#nullable restore
#line 31 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1718, Model.User.Name, 1718, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1744, "\"", 1782, 1);
#nullable restore
#line 31 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1756, AbpUserBase.MaxNameLength, 1756, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row required\">\r\n                    <label class=\"col-md-3 col-form-label\" for=\"surname\">");
#nullable restore
#line 35 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                    Write(L("Surname"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-9\">\r\n                        <input id=\"surname\" type=\"text\" class=\"form-control\" name=\"Surname\"");
                BeginWriteAttribute("value", " value=\"", 2124, "\"", 2151, 1);
#nullable restore
#line 37 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2132, Model.User.Surname, 2132, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2161, "\"", 2202, 1);
#nullable restore
#line 37 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2173, AbpUserBase.MaxSurnameLength, 2173, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row required\">\r\n                    <label class=\"col-md-3 col-form-label\" for=\"email\">");
#nullable restore
#line 41 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                  Write(L("EmailAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-9\">\r\n                        <input id=\"email\" type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                BeginWriteAttribute("value", " value=\"", 2551, "\"", 2583, 1);
#nullable restore
#line 43 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2559, Model.User.EmailAddress, 2559, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2593, "\"", 2639, 1);
#nullable restore
#line 43 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2605, AbpUserBase.MaxEmailAddressLength, 2605, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group row\">\r\n                    <label class=\"col-md-3 col-form-label\" for=\"IsActive\">");
#nullable restore
#line 47 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"col-md-9\">\r\n                        <input id=\"IsActive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" ");
#nullable restore
#line 49 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                      Write(Model.User.IsActive ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div role=\"tabpanel\" class=\"tab-pane container animated fadeIn\" id=\"edit-user-roles\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 55 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <input type=\"checkbox\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 3412, "\"", 3440, 1);
#nullable restore
#line 58 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3420, role.NormalizedName, 3420, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3441, "\"", 3466, 1);
#nullable restore
#line 58 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3449, role.Description, 3449, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"filled-in\"");
                BeginWriteAttribute("id", " id=\"", 3485, "\"", 3509, 1);
#nullable restore
#line 58 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3490, $"role{role.Id}", 3490, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 58 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                                                                                             Write(Model.UserIsInRole(role) ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3594, "\"", 3619, 1);
#nullable restore
#line 59 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3600, $"role{role.Id}", 3600, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3620, "\"", 3645, 1);
#nullable restore
#line 59 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3628, role.DisplayName, 3628, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 59 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                  Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n");
#nullable restore
#line 61 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 66 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ebce2fe6190fa0833b6a5e7b8131ff5316ea8c320126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Users\_EditModal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditUserModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591