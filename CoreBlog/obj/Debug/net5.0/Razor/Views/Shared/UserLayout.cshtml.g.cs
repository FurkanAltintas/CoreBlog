#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d546d06e86e5912967ccb603200c5c8ee743361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_UserLayout), @"mvc.1.0.view", @"/Views/Shared/UserLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d546d06e86e5912967ccb603200c5c8ee743361", @"/Views/Shared/UserLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_UserLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 header-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d546d06e86e5912967ccb603200c5c8ee7433614752", async() => {
                WriteLiteral("\r\n    <title>Weblog - ");
#nullable restore
#line 5 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""utf-8"">
    <meta name=""keywords"" content=""Weblog a Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design"" />

    <script>
        addEventListener(""load"", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <link");
                BeginWriteAttribute("href", " href=\"", 689, "\"", 738, 1);
#nullable restore
#line 20 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 696, Url.Content("~/weblog/css/bootstrap.css"), 696, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\'stylesheet\' type=\'text/css\' />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 803, "\"", 849, 1);
#nullable restore
#line 21 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 810, Url.Content("~/weblog/css/single.css"), 810, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 862, "\"", 907, 1);
#nullable restore
#line 22 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 869, Url.Content("~/weblog/css/style.css"), 869, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\'stylesheet\' type=\'text/css\' />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 955, "\"", 1010, 1);
#nullable restore
#line 23 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 962, Url.Content("~/weblog/css/fontawesome-all.css"), 962, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 1040, "\"", 1171, 1);
#nullable restore
#line 24 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 1047, Url.Content("//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800"), 1047, 124, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n          rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d546d06e86e5912967ccb603200c5c8ee7433618904", async() => {
                WriteLiteral("\r\n    <!--Header-->\r\n\r\n    <header>\r\n        <div class=\"top-bar_sub_w3layouts container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4 logo text-left\">\r\n                    <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\"", 1447, "\"", 1481, 1);
#nullable restore
#line 35 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 1454, Url.Action("Index","Blog"), 1454, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-linode\"></i> FaBlog\r\n                    </a>\r\n                </div>\r\n                ");
#nullable restore
#line 39 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/Home/Account.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""col-md-4 log-icons text-right"">
                    <ul class=""social_list1 mt-3"">

                        <li>
                            <a href=""#"" class=""facebook1 mx-2"">
                                <i class=""fab fa-facebook-f""></i>

                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""twitter2"">
                                <i class=""fab fa-twitter""></i>

                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""dribble3 mx-2"">
                                <i class=""fab fa-dribbble""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""pin"">
                                <i class=""fab fa-pinterest-p""></i>
                            </a>
                        </li>
                 ");
                WriteLiteral(@"   </ul>
                </div>
            </div>
        </div>

        <div class=""header_top"" id=""home"">
            <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                <button class=""navbar-toggler navbar-toggler-right mx-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 3479, "\"", 3513, 1);
#nullable restore
#line 79 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 3486, Url.Action("Index","Blog"), 3486, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                Anasayfa
                                <span class=""sr-only"">(current)</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 3790, "\"", 3825, 1);
#nullable restore
#line 85 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 3797, Url.Action("Index","About"), 3797, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Hakk??m??zda</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 3968, "\"", 4002, 1);
#nullable restore
#line 88 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 3975, Url.Action("Index","Blog"), 3975, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Bloglar</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 4142, "\"", 4179, 1);
#nullable restore
#line 91 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 4149, Url.Action("Index","Contact"), 4149, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">??leti??im</a>\r\n                        </li>\r\n                    </ul>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d546d06e86e5912967ccb603200c5c8ee74336114370", async() => {
                    WriteLiteral("\r\n                        <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Aranacak kelime...\" name=\"Search\"");
                    BeginWriteAttribute("required", " required=\"", 4473, "\"", 4484, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        <button class=\"btn btn1 my-2 my-sm-0\" type=\"submit\">\r\n                            <i class=\"fas fa-search\"></i>\r\n                        </button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </nav>\r\n        </div>\r\n    </header>\r\n    <!--//header-->\r\n    <!--/banner-->\r\n    <div class=\"banner-inner\">\r\n    </div>\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 4930, "\"", 4952, 1);
#nullable restore
#line 110 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 4937, Url.Action(""), 4937, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 110 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
                                 Write(Html.ViewContext.RouteData.Values["controller"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 112 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n    </ol>\r\n    <!--//banner-->\r\n    <!--/main-->\r\n    ");
#nullable restore
#line 116 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--//main-->\r\n    <!--footer-->\r\n    ");
#nullable restore
#line 119 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Home/Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!---->\r\n    <!-- js -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5317, "\"", 5370, 1);
#nullable restore
#line 122 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 5323, Url.Content("~/weblog/js/jquery-2.2.3.min.js"), 5323, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- //js -->\r\n    <!--/ start-smoth-scrolling -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5450, "\"", 5495, 1);
#nullable restore
#line 125 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 5456, Url.Content("~/weblog/js/move-top.js"), 5456, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5519, "\"", 5562, 1);
#nullable restore
#line 126 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 5525, Url.Content("~/weblog/js/easing.js"), 5525, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        jQuery(document).ready(function ($) {
            $("".scroll"").click(function (event) {
                event.preventDefault();
                $('html,body').animate({
                    scrollTop: $(this.hash).offset().top
                }, 900);
            });
        });
    </script>
    <!--// end-smoth-scrolling -->
    <script>
        $(document).ready(function () {
            /*
                                    var defaults = {
                                            containerID: 'toTop', // fading element id
                                        containerHoverID: 'toTopHover', // fading element hover id
                                        scrollSpeed: 1200,
                                        easingType: 'linear'
                                        };
                                    */

            $().UItoTop({
                easingType: 'easeOutQuart'
            });

        });
    </script>
    <a href=""");
                WriteLiteral("#home\" class=\"scroll\" id=\"toTop\" style=\"display: block;\">\r\n        <span id=\"toTopHover\" style=\"opacity: 1;\"> </span>\r\n    </a>\r\n    <!-- //Custom-JavaScript-File-Links -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6772, "\"", 6818, 1);
#nullable restore
#line 159 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\UserLayout.cshtml"
WriteAttributeValue("", 6778, Url.Content("~/weblog/js/bootstrap.js"), 6778, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
