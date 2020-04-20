#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07eee4e569678d6e6aecc73d815e3dc3e6b4f83d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RightNavbarLanguageSwitch_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
using BookingSystem.Web.Views.Shared.Components.RightNavbarLanguageSwitch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07eee4e569678d6e6aecc73d815e3dc3e6b4f83d", @"/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RightNavbarLanguageSwitch_Default : BookingSystem.Web.Views.BookingSystemRazorPage<RightNavbarLanguageSwitchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"nav-item dropdown\">\r\n    <a href=\"javascript:void(0);\" class=\"nav-link\" data-toggle=\"dropdown\" role=\"button\">\r\n        <i");
            BeginWriteAttribute("class", " class=\"", 253, "\"", 288, 1);
#nullable restore
#line 6 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 261, Model.CurrentLanguage.Icon, 261, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 289, "\"", 331, 1);
#nullable restore
#line 6 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 297, Model.CurrentLanguage.DisplayName, 297, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n        <span class=\"d-none d-md-inline-block\">");
#nullable restore
#line 7 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
                                          Write(Model.CurrentLanguage.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n    <div class=\"dropdown-menu dropdown-menu-right p-0\">\r\n");
#nullable restore
#line 10 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
         foreach (var language in Model.Languages)
        {
            if (language.Name != Model.CurrentLanguage.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 793, 5);
#nullable restore
#line 14 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 683, ApplicationPath, 683, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 701, "AbpLocalization/ChangeCulture?cultureName=", 701, 42, true);
#nullable restore
#line 14 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 743, language.Name, 743, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, "&returnUrl=", 759, 11, true);
#nullable restore
#line 14 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 770, Context.Request.Path, 770, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 819, "\"", 846, 2);
            WriteAttributeValue("", 827, "mr-2", 827, 4, true);
#nullable restore
#line 15 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
WriteAttributeValue(" ", 831, language.Icon, 832, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 15 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
                                                   Write(language.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 17 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\RightNavbarLanguageSwitch\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RightNavbarLanguageSwitchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591