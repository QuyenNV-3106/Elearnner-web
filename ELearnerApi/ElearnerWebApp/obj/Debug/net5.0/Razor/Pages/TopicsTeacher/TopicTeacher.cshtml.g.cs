#pragma checksum "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a83e0eea39dab0c934252dbe919c682db24e654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ElearnerWebApp.Pages.TopicsTeacher.Pages_TopicsTeacher_TopicTeacher), @"mvc.1.0.razor-page", @"/Pages/TopicsTeacher/TopicTeacher.cshtml")]
namespace ElearnerWebApp.Pages.TopicsTeacher
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
#line 1 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\_ViewImports.cshtml"
using ElearnerWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a83e0eea39dab0c934252dbe919c682db24e654", @"/Pages/TopicsTeacher/TopicTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b12a3d7ff3a102b93674b2fc9c1b9589c9f37d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_TopicsTeacher_TopicTeacher : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
  
    ViewData["Title"] = "TopicTeacher";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TopicTeacher</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic[0].SubTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic[0].ImgUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic[0].Kind));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic[0].MeetUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
 foreach (var item in Model.Topic) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1162, "\"", 1180, 1);
#nullable restore
#line 42 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
WriteAttributeValue("", 1168, item.ImgUrl, 1168, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kind));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
           Write(Html.DisplayFor(modelItem => item.MeetUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1434, "\"", 1454, 1);
#nullable restore
#line 51 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
WriteAttributeValue("", 1441, item.MeetUrl, 1441, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Join Now</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "D:\Elearnner-web\ELearnerApi\ElearnerWebApp\Pages\TopicsTeacher\TopicTeacher.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElearnerWebApp.Pages.TopicsTeacher.TopicTeacherModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ElearnerWebApp.Pages.TopicsTeacher.TopicTeacherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ElearnerWebApp.Pages.TopicsTeacher.TopicTeacherModel>)PageContext?.ViewData;
        public ElearnerWebApp.Pages.TopicsTeacher.TopicTeacherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
