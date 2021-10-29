#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d84752d5a980caaac778d2618a2362eaaa527b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Add), @"mvc.1.0.view", @"/Views/Blog/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d84752d5a980caaac778d2618a2362eaaa527b", @"/Views/Blog/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
 using (Html.BeginForm("Add", "Blog", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control", placeholder = "Başlık" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.Category, "Kategori Seçiniz", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.ValidationMessageFor(x => x.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.TextAreaFor(x => x.Description, 15, 0, new { @class = "form-control", placeholder = "İçerik" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.ValidationMessageFor(x => x.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.TextBoxFor(x => x.Thumbnail, new { @class = "form-control", placeholder = "Thumbnail" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
   Write(Html.TextBoxFor(x => x.Image, new { @class = "form-control", placeholder = "Görsel" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-success\">Blog Ekle</button>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Blog\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
