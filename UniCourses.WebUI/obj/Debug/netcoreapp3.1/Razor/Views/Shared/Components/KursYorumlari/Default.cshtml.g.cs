#pragma checksum "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b86c461414584d7fc353ce00d2d7d9e89706680e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_KursYorumlari_Default), @"mvc.1.0.view", @"/Views/Shared/Components/KursYorumlari/Default.cshtml")]
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
#line 1 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86c461414584d7fc353ce00d2d7d9e89706680e", @"/Views/Shared/Components/KursYorumlari/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8425bc63e89a2dee5cabaec1ea59febb30caf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_KursYorumlari_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniCourses.Dal.Entities.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("</UniCourses.WebUI.ViewComponents.KursYorumlari>\n\n\n    <div>\n");
#nullable restore
#line 6 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
         foreach (Comment comment in Model)
        {
            if (comment.State == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\n                <div class=\"row m-3\">\n                    <div class=\"col-md-10\">\n                        <strong class=\"text-info\">-");
#nullable restore
#line 13 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                                              Write(comment.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <span class=\"text-muted\">");
#nullable restore
#line 13 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                                                                                                    Write(comment.CommentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tarihinde Yorumladı</span>\n                    </div>\n                    <i>\"");
#nullable restore
#line 15 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                   Write(comment.UserComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</i>\n                    <div style=\"width:100%;\"><p style=\"text-align:right;\"></p></div>\n                </div>\n            </ul>\n");
#nullable restore
#line 19 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniCourses.Dal.Entities.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
