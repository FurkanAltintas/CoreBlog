#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\Notifications\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73808d38e6a997cf411c2bdf7bd64b5251f6ad37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notifications_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notifications/Default.cshtml")]
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
#line 1 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73808d38e6a997cf411c2bdf7bd64b5251f6ad37", @"/Views/Shared/Components/Notifications/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notifications_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<li class=""nav-item dropdown"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""mdi mdi-bell-outline""></i>
        <span class=""count-symbol bg-danger""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <h6 class=""p-3 mb-0"">Notifications</h6>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-success"">
                    <i class=""mdi mdi-calendar""></i>
                </div>
            </div>
            <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
                <h6 class=""preview-subject font-weight-normal mb-1"">Event today</h6>
                <p class=""text-gray ellipsis mb-0""> Just a reminder that you have an event today </p>
       ");
            WriteLiteral(@"     </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-warning"">
                    <i class=""mdi mdi-settings""></i>
                </div>
            </div>
            <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
                <h6 class=""preview-subject font-weight-normal mb-1"">Settings</h6>
                <p class=""text-gray ellipsis mb-0""> Update dashboard </p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-info"">
                    <i class=""mdi mdi-link-variant""></i>
                </div>
            </div>
            <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
    ");
            WriteLiteral(@"            <h6 class=""preview-subject font-weight-normal mb-1"">Launch Admin</h6>
                <p class=""text-gray ellipsis mb-0""> New admin wow! </p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <h6 class=""p-3 mb-0 text-center"">See all notifications</h6>
    </div>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591