#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe2682c5abc4fad5ad6bd8c7203572744484823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListByWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe2682c5abc4fad5ad6bd8c7203572744484823", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListByWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Yazıları</h4>\r\n");
#nullable restore
#line 5 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a href=\"single.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 281, "\"", 298, 1);
#nullable restore
#line 10 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml"
WriteAttributeValue("", 287, item.Image, 287, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 317, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n                <h5>\r\n                    <a href=\"single.html\">");
#nullable restore
#line 15 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 19 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                                Write(item.CreateDate.ToString("dd MMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\Components\BlogListByWriter\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
