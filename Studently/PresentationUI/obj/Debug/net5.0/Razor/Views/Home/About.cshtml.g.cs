#pragma checksum "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ecdd935477f9bb80ebf837189420f71533120ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\_ViewImports.cshtml"
using PresentationUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\_ViewImports.cshtml"
using PresentationUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecdd935477f9bb80ebf837189420f71533120ea", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce9b632e2ce9c0340883b952cecfc2372e13a88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid position-absolute w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit: cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Header Start -->
<div class=""container-fluid bg-primary py-5 mb-5 page-header"">
    <div class=""container py-5"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-10 text-center"">
                <h1 class=""display-3 text-white animated slideInDown"">About Us</h1>
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb justify-content-center"">
                        <li class=""breadcrumb-item""><a class=""text-white"" href=""#"">Home</a></li>
                        <li class=""breadcrumb-item""><a class=""text-white"" href=""#"">Pages</a></li>
                        <li class=""breadcrumb-item text-white active"" aria-current=""page"">About</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- Header End -->
<!-- Service Start -->
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""row g-4"">
            <div class=""col-lg-3 col-sm-6 wow fadeInUp"" dat");
            WriteLiteral(@"a-wow-delay=""0.1s"">
                <div class=""service-item text-center pt-3"">
                    <div class=""p-4"">
                        <i class=""fa fa-3x fa-graduation-cap text-primary mb-4""></i>
                        <h5 class=""mb-3"">Skilled Instructors</h5>
                        <p>Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6 wow fadeInUp"" data-wow-delay=""0.3s"">
                <div class=""service-item text-center pt-3"">
                    <div class=""p-4"">
                        <i class=""fa fa-3x fa-globe text-primary mb-4""></i>
                        <h5 class=""mb-3"">Online Classes</h5>
                        <p>Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6 wow fadeInUp"" data-wow-delay=""0.5s"">
 ");
            WriteLiteral(@"               <div class=""service-item text-center pt-3"">
                    <div class=""p-4"">
                        <i class=""fa fa-3x fa-home text-primary mb-4""></i>
                        <h5 class=""mb-3"">Home Projects</h5>
                        <p>Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6 wow fadeInUp"" data-wow-delay=""0.7s"">
                <div class=""service-item text-center pt-3"">
                    <div class=""p-4"">
                        <i class=""fa fa-3x fa-book-open text-primary mb-4""></i>
                        <h5 class=""mb-3"">Book Library</h5>
                        <p>Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Service End -->
<!-- About Start -->
<div class=""container-xxl py-5"">
   ");
            WriteLiteral(" <div class=\"container\">\r\n        <div class=\"row g-5\">\r\n            <div class=\"col-lg-6 wow fadeInUp\" data-wow-delay=\"0.1s\" style=\"min-height: 400px;\">\r\n                <div class=\"position-relative h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ecdd935477f9bb80ebf837189420f71533120ea9183", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-6 wow fadeInUp"" data-wow-delay=""0.3s"">
                <h6 class=""section-title bg-white text-start text-primary pe-3"">About Us</h6>
                <h1 class=""mb-4"">Welcome to eLEARNING</h1>
                <p class=""mb-4"">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.</p>
                <p class=""mb-4"">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>
                <div class=""row gy-2 gx-4 mb-4"">
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i>Skilled Instructors</p>
                    </div>
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i");
            WriteLiteral(@">Online Classes</p>
                    </div>
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i>International Certificate</p>
                    </div>
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i>Skilled Instructors</p>
                    </div>
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i>Online Classes</p>
                    </div>
                    <div class=""col-sm-6"">
                        <p class=""mb-0""><i class=""fa fa-arrow-right text-primary me-2""></i>International Certificate</p>
                    </div>
                </div>
                <a class=""btn btn-primary py-3 px-5 mt-2""");
            BeginWriteAttribute("href", " href=\"", 5451, "\"", 5458, 0);
            EndWriteAttribute();
            WriteLiteral(@">Read More</a>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Team Start -->
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title bg-white text-center text-primary px-3"">Instructors</h6>
            <h1 class=""mb-5"">Expert Instructors</h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 120 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
                     foreach (var item in Model)
		    {
                  

                    //string imgId = (item.Id).ToString();
                    //string imgUrl = "\"" + "~/img/team-" + imgId + ".jpg" + "\"";


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                        <div class=\"team-item bg-light\">\r\n                            <div class=\"overflow-hidden\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ecdd935477f9bb80ebf837189420f71533120ea13732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""position-relative d-flex justify-content-center"" style=""margin-top: -23px;"">
                                <div class=""bg-light d-flex justify-content-center pt-2 px-1"">
                                    <a class=""btn btn-sm-square btn-primary mx-1""");
            BeginWriteAttribute("href", " href=\"", 6798, "\"", 6805, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                                    <a class=\"btn btn-sm-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 6927, "\"", 6934, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                                    <a class=\"btn btn-sm-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 7053, "\"", 7060, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text-center p-4\">\r\n                                <h5 class=\"mb-0\">");
#nullable restore
#line 140 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 140 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
                                                       Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <small>");
#nullable restore
#line 141 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
                                  Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 145 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\PresentationUI\Views\Home\About.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Team End -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591