#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c271fa988f08b871d3d5ac65f20c8483c26ec8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Index), @"mvc.1.0.view", @"/Views/Directors/Index.cshtml")]
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
#line 5 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
using Filmography.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c271fa988f08b871d3d5ac65f20c8483c26ec8a4", @"/Views/Directors/Index.cshtml")]
    public class Views_Directors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Filmography.Models.Director>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Directors</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No directors have been added yet!</h3>\r\n");
#nullable restore
#line 13 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
 foreach (Director director in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 17 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
 Write(Html.ActionLink($"{director.DirectorName}", "Details", new { id = director.DirectorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 20 "C:\Users\ultra\desktop\Filmography\Views\Directors\Index.cshtml"
Write(Html.ActionLink("Add new director", "Create", "Directors"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Filmography.Models.Director>> Html { get; private set; }
    }
}
#pragma warning restore 1591
