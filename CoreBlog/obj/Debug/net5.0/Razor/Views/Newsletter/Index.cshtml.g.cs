#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Newsletter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9263f66388d68001fb2d91e0d2cb4b18fc9173f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Newsletter_Index), @"mvc.1.0.view", @"/Views/Newsletter/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9263f66388d68001fb2d91e0d2cb4b18fc9173f", @"/Views/Newsletter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Newsletter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreBlog.Models.NewsletterById>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Haber bültenimize kaydolun</h4>\r\n    <p>Gizliliğinize saygı duyuyoruz. Asla spam yok! </p>\r\n");
#nullable restore
#line 6 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Newsletter\Index.cshtml"
     using (Html.BeginForm("Index", "Newsletter", FormMethod.Post))
    {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Newsletter\Index.cshtml"
       Write(Html.HiddenFor(x=>x.BlogId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Newsletter\Index.cshtml"
       Write(Html.TextBoxFor(x=>x.Mail,new { type="email", placeholder = "Email", required="" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Abone Ol\">\r\n");
#nullable restore
#line 13 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Newsletter\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreBlog.Models.NewsletterById> Html { get; private set; }
    }
}
#pragma warning restore 1591