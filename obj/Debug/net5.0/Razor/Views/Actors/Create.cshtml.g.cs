#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8a830120c5e6fddaf45386f4e12c5da93d70a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Create), @"mvc.1.0.view", @"/Views/Actors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8a830120c5e6fddaf45386f4e12c5da93d70a1f", @"/Views/Actors/Create.cshtml")]
    public class Views_Actors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmography.Models.Actor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 8 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
        Write(Html.ActionLink("ACTORS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n<div id=\"push\"></div>\r\n<h4>Add an Actor:</h4>\r\n");
#nullable restore
#line 12 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
Write(Html.LabelFor(model => model.ActorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
Write(Html.TextBoxFor(model => model.ActorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new Actor\" />\r\n");
#nullable restore
#line 17 "C:\Users\ultra\desktop\Filmography\Views\Actors\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmography.Models.Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591
