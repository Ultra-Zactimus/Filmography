#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa6e12b088f79fdc2c8897e0b932e9f189c4c03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Composers_Delete), @"mvc.1.0.view", @"/Views/Composers/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa6e12b088f79fdc2c8897e0b932e9f189c4c03", @"/Views/Composers/Delete.cshtml")]
    public class Views_Composers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmography.Models.Composer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 8 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
        Write(Html.ActionLink("COMPOSERS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n\r\n<h2>Are you sure you want to delete this?</h2>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.ComposerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 13 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
                                              Write(Html.DisplayFor(model => model.ComposerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 17 "C:\Users\ultra\desktop\Filmography\Views\Composers\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"get-low\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmography.Models.Composer> Html { get; private set; }
    }
}
#pragma warning restore 1591
