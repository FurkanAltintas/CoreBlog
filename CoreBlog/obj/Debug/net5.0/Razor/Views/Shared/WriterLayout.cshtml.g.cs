#pragma checksum "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96b02d38bfa1a429364c4a025e769c6c381e968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_WriterLayout), @"mvc.1.0.view", @"/Views/Shared/WriterLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96b02d38bfa1a429364c4a025e769c6c381e968", @"/Views/Shared/WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fb92326d714328fe53868e51668a47047da3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dashboard/assets/images/logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dashboard/assets/images/logo-mini.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dashboard/assets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Writer/Sidebar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Writer/Footer.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96b02d38bfa1a429364c4a025e769c6c381e9687191", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <title>Purple Admin - ");
#nullable restore
#line 6 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 237, "\"", 322, 1);
#nullable restore
#line 7 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 244, Url.Content("~/dashboard/assets/vendors/mdi/css/materialdesignicons.min.css"), 244, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 351, "\"", 427, 1);
#nullable restore
#line 8 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 358, Url.Content("~/dashboard/assets/vendors/css/vendor.bundle.base.css"), 358, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 456, "\"", 511, 1);
#nullable restore
#line 9 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 463, Url.Content("~/dashboard/assets/css/style.css"), 463, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"shortcut icon\"");
                BeginWriteAttribute("href", " href=\"", 543, "\"", 603, 1);
#nullable restore
#line 10 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 550, Url.Content("~/dashboard/assets/images/favicon.ico"), 550, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96b02d38bfa1a429364c4a025e769c6c381e96810383", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <nav class=""navbar default-layout-navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""text-center navbar-brand-wrapper d-flex align-items-center justify-content-center"">
                <a class=""navbar-brand brand-logo"" href=""index.html"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a96b02d38bfa1a429364c4a025e769c6c381e96810962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\n                <a class=\"navbar-brand brand-logo-mini\" href=\"index.html\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a96b02d38bfa1a429364c4a025e769c6c381e96812216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-stretch"">
                <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                    <span class=""mdi mdi-menu""></span>
                </button>
                <div class=""search-field d-none d-md-block"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96b02d38bfa1a429364c4a025e769c6c381e96813776", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <div class=""input-group-prepend bg-transparent"">
                                <i class=""input-group-text border-0 mdi mdi-magnify""></i>
                            </div>
                            <input type=""text"" class=""form-control bg-transparent border-0"" placeholder=""Search projects"">
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <ul class=""navbar-nav navbar-nav-right"">

                    <li class=""nav-item nav-profile dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""profileDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
                            <div class=""nav-profile-img"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a96b02d38bfa1a429364c4a025e769c6c381e96816066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <span class=""availability-status online""></span>
                            </div>
                            <div class=""nav-profile-text"">
                                <p class=""mb-1 text-black"">Furkan Altıntaş</p>
                            </div>
                        </a>
                        <div class=""dropdown-menu navbar-dropdown"" aria-labelledby=""profileDropdown"">
                            <a class=""dropdown-item"" href=""#"">
                                <i class=""mdi mdi-cached mr-2 text-success""></i> Activity Log
                            </a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 3169, "\"", 3207, 1);
#nullable restore
#line 50 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 3176, Url.Action("LogOut","Account"), 3176, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <i class=""mdi mdi-logout mr-2 text-primary""></i> Signout
                            </a>
                        </div>
                    </li>

                    <li class=""nav-item d-none d-lg-block full-screen-link"">
                        <a class=""nav-link"">
                            <i class=""mdi mdi-fullscreen"" id=""fullscreen-button""></i>
                        </a>
                    </li>

                    ");
#nullable restore
#line 62 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
               Write(await Component.InvokeAsync("Messages"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    ");
#nullable restore
#line 64 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
               Write(await Component.InvokeAsync("Notifications"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n                    <li class=\"nav-item nav-logout d-none d-lg-block\">\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 3898, "\"", 3936, 1);
#nullable restore
#line 68 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 3905, Url.Action("LogOut","Account"), 3905, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""mdi mdi-power""></i>
                        </a>
                    </li>

                    <li class=""nav-item nav-settings d-none d-lg-block"">
                        <a class=""nav-link"" href=""#"">
                            <i class=""mdi mdi-format-line-spacing""></i>
                        </a>
                    </li>

                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>

        <div class=""container-fluid page-body-wrapper"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a96b02d38bfa1a429364c4a025e769c6c381e96820670", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <div class=\"main-panel\">\n                <div class=\"content-wrapper\">\n                    <div class=\"page-header\">\n                        <h3 class=\"page-title\"> ");
#nullable restore
#line 91 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
                                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\n                        <nav aria-label=\"breadcrumb\">\n                            <ol class=\"breadcrumb\">\n                                <li class=\"breadcrumb-item\"><a href=\"#\">");
#nullable restore
#line 94 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
                                                                   Write(this.ViewContext.RouteData.Values["controller"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\n                                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 95 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
                                                                                  Write(this.ViewContext.RouteData.Values["action"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n                            </ol>\n                        </nav>\n                    </div>\n\n                    ");
#nullable restore
#line 100 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                </div>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a96b02d38bfa1a429364c4a025e769c6c381e96823662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <script");
                BeginWriteAttribute("src", " src=\"", 5545, "\"", 5618, 1);
#nullable restore
#line 108 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5551, Url.Content("~/dashboard/assets/vendors/js/vendor.bundle.base.js"), 5551, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 5641, "\"", 5711, 1);
#nullable restore
#line 109 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5647, Url.Content("~/dashboard/assets/vendors/chart.js/Chart.min.js"), 5647, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 5734, "\"", 5791, 1);
#nullable restore
#line 110 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5740, Url.Content("~/dashboard/assets/js/off-canvas.js"), 5740, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 5814, "\"", 5879, 1);
#nullable restore
#line 111 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5820, Url.Content("~/dashboard/assets/js/hoverable-collapse.js"), 5820, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 5902, "\"", 5953, 1);
#nullable restore
#line 112 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5908, Url.Content("~/dashboard/assets/js/misc.js"), 5908, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 5976, "\"", 6032, 1);
#nullable restore
#line 113 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 5982, Url.Content("~/dashboard/assets/js/dashboard.js"), 5982, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 6055, "\"", 6110, 1);
#nullable restore
#line 114 "C:\Users\furka\Documents\GitHub\CoreBlog\CoreBlog\Views\Shared\WriterLayout.cshtml"
WriteAttributeValue("", 6061, Url.Content("~/dashboard/assets/js/todolist.js"), 6061, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n\n");
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
            WriteLiteral("\n</html>");
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
