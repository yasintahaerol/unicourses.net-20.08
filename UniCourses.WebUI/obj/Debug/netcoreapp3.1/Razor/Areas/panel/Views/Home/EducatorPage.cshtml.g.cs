#pragma checksum "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Areas\panel\Views\Home\EducatorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c20ace9b7edcce53e20b77082cf4f01033cae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_panel_Views_Home_EducatorPage), @"mvc.1.0.view", @"/Areas/panel/Views/Home/EducatorPage.cshtml")]
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
#line 1 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Areas\panel\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c20ace9b7edcce53e20b77082cf4f01033cae3", @"/Areas/panel/Views/Home/EducatorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b90faa6661773057164976a6feb5bf5a8ebb06", @"/Areas/panel/Views/_ViewImports.cshtml")]
    public class Areas_panel_Views_Home_EducatorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Educator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Areas\panel\Views\Home\EducatorPage.cshtml"
  
    ViewData["Title"] = "EducatorPage";
    Layout = "~/Areas/panel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n\n    <li>\n        ");
#nullable restore
#line 10 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Areas\panel\Views\Home\EducatorPage.cshtml"
   Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </li>\n    <li>\n        ");
#nullable restore
#line 13 "C:\Users\YASIN\Desktop\19.08\UniCourses-master\UniCourses.WebUI\Areas\panel\Views\Home\EducatorPage.cshtml"
   Write(Model.Courses);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </li>\n</ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Educator> Html { get; private set; }
    }
}
#pragma warning restore 1591
