#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692f7bc7c184425c41cfcbf9c549356baec044ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Create), @"mvc.1.0.view", @"/Views/Directors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692f7bc7c184425c41cfcbf9c549356baec044ed", @"/Views/Directors/Create.cshtml")]
    public class Views_Directors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmography.Models.Director>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 8 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
        Write(Html.ActionLink("DIRECTORS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n<div id=\"push\"></div>\r\n<h4>Add Director:</h4>\r\n");
#nullable restore
#line 12 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
Write(Html.LabelFor(model => model.DirectorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
Write(Html.TextBoxFor(model => model.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add New Director\" />\r\n");
#nullable restore
#line 17 "C:\Users\ultra\desktop\Filmography\Views\Directors\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmography.Models.Director> Html { get; private set; }
    }
}
#pragma warning restore 1591
