#pragma checksum "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76dde24572afdbb1140bbcda13d5ece82e14a45c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
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
#line 1 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\_ViewImports.cshtml"
using AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\_ViewImports.cshtml"
using AdminPanel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76dde24572afdbb1140bbcda13d5ece82e14a45c", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cb09a286142a0af4f033f761ef1537daca5904", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDeleteById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-danger text-white ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-warning text-white ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<main class=""main-content position-relative max-height-vh-100 h-100 border-radius-lg "">
        <!-- partial -->
<div class=""container-fluid py-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card my-4"">
                <div class=""card-header p-0 position-relative mt-n4 mx-3 z-index-2"">
                    <div class=""bg-gradient-primary shadow-primary border-radius-lg pt-4 pb-3"">
                        <h6 class=""text-white text-capitalize ps-3"">Student List</h6>                         
                    </div>
                </div>
                <div class=""card-body px-0 pb-2"">
                    <div class=""table-responsive p-0"">
                        <table class=""table align-items-center mb-0"">
                                <thead style=""padding:0px !important"" ;>
                                <tr>
                                        <th class=""text-uppercase text-secondary  text-xs font-weight-bolder opacity-7 ps-2"">Student Id</th>
  ");
            WriteLiteral(@"                                      <th class=""text-uppercase text-secondary text-xs font-weight-bolder opacity-7"">Student Name/Surname</th>
                                        <th class=""text-uppercase text-secondary text-xs font-weight-bolder opacity-7"">Student Number</th>
                                        <th class=""text-uppercase text-secondary text-xs font-weight-bolder opacity-7"">Role</th>

                                        <th class="" text-secondary text-xs font-weight-bolder"" style=""display:flex; justify-content:center"">
                                            <a href=""/Student/Add"" class=""btn  btn-success text-white mb-0 align-middle"" width=""100"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-plus"" viewBox=""0 0 16 16"">
                                                    <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8");
            WriteLiteral(" 4z\" />\r\n                                                </svg>\r\n                                            </a>\r\n                                        </th>\r\n                                </tr>\r\n\r\n                            </thead>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                  
                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <tbody>
                                                        <tr>
                                                            <td class=""align-middle text-center text"">
                                                                <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 44 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                    Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>                                                
                                                            </td>
                                                            <td class =""align-middle text-center text"">
                                                                <div class=""d-flex py-1"">
                                                                    <div>
                                                                        <img src=""../assets/img/team-2.jpg"" class=""avatar avatar-sm me-3 border-radius-lg"" alt=""user1"">
                                                                    </div>
                                                                    <div class=""d-flex flex-column justify-content-center"">
                                                                        <h6 class=""mb-0 text"">");
#nullable restore
#line 52 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                         Write(item.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                           Write(item.StudentSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                                                        <p class=\"text-xs text-secondary mb-0\">");
#nullable restore
#line 53 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                          Write(item.StudentMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                            
                                                            <td class=""align-middle text-center text"">
                                                                    <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 59 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                        Write(item.StudentNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                            </td>
                                                            <td class=""align-middle text-center text"">
                                                                <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 62 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                    Write(item.UserRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                             </td>\r\n                                                            <td class=\"align-middle text-center text\">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dde24572afdbb1140bbcda13d5ece82e14a45c12181", async() => {
                WriteLiteral(@"
                                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-x"" viewBox=""0 0 16 16"">
                                                                        <path d=""M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z"" />
                                                                    </svg>
                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                                             WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td class=\"align-middle text-center text\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dde24572afdbb1140bbcda13d5ece82e14a45c15571", async() => {
                WriteLiteral(@"
                                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
                                                                    <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"" />
                                                                    <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"" />
                                                                </svg>
                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                                                                                             WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </td>\r\n                                                        </tr>\r\n                                                    </tbody>\r\n");
#nullable restore
#line 81 "C:\Users\gulbe\OneDrive\Masaüstü\REA\Studently\AdminPanel\Views\Student\StudentList.cshtml"
                                    } 
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div></main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
