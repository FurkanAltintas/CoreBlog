#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383af40e2e2805b0be08b2da27a46dac275e86ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterRecentPost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterRecentPost/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383af40e2e2805b0be08b2da27a46dac275e86ee", @"/Views/Shared/Components/FooterRecentPost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterRecentPost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-4 footer-grid-agileits-w3ls text-left\">\r\n    <div class=\"tech-btm\">\r\n        <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 6 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-grids row mb-3\">\r\n                <div class=\"col-md-5 blog-grid-left\">\r\n                    <a href=\"single.html\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 362, "\"", 379, 1);
#nullable restore
#line 11 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml"
WriteAttributeValue("", 368, item.Image, 368, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 411, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div class=\"col-md-7 blog-grid-right\">\r\n                    <h5>\r\n                        <a href=\"single.html\">");
#nullable restore
#line 16 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </h5>\r\n                    <div class=\"sub-meta\">\r\n                        <span>\r\n                            <i class=\"far fa-clock\"></i>");
#nullable restore
#line 20 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml"
                                                   Write(item.CreateDate.ToString("dd MMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\FooterRecentPost\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
