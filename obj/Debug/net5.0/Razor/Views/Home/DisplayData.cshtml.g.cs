#pragma checksum "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\Home\DisplayData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d733e9df92eb94d88e47fe40c790499841b7969c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayData), @"mvc.1.0.view", @"/Views/Home/DisplayData.cshtml")]
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
#line 1 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\_ViewImports.cshtml"
using DojoSurveyValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\_ViewImports.cshtml"
using DojoSurveyValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d733e9df92eb94d88e47fe40c790499841b7969c", @"/Views/Home/DisplayData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a083a02d55da6e5f7c5dfa6b3e462f77f713a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dojo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"w-50 mx-auto\">\r\n    <h1>Name: ");
#nullable restore
#line 4 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\Home\DisplayData.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>DojoLocation: ");
#nullable restore
#line 5 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\Home\DisplayData.cshtml"
                 Write(Model.DojoLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Fav Language: ");
#nullable restore
#line 6 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\Home\DisplayData.cshtml"
                 Write(Model.FavLang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>Comment: ");
#nullable restore
#line 7 "D:\CodingDojo\CSharp\asp_net\DojoSurveyValidations\Views\Home\DisplayData.cshtml"
            Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <a href=\"/\" class=\"btn btn-lg btn-primary\">Back</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dojo> Html { get; private set; }
    }
}
#pragma warning restore 1591
