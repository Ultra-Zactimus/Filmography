#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d6e5adea3a35650d7235ba615e7894df109f056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_AddActor), @"mvc.1.0.view", @"/Views/Movies/AddActor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6e5adea3a35650d7235ba615e7894df109f056", @"/Views/Movies/AddActor.cshtml")]
    public class Views_Movies_AddActor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmography.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 8 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
        Write(Html.ActionLink("MOVIES", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n<div id=\"push\"></div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
 if (@ViewBag.num != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2>Add an actor</h2>\r\n  <h4>Add an actor to this movie: ");
#nullable restore
#line 15 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
                             Write(Html.DisplayFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 16 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
Write(Html.Hidden("MovieId"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
Write(Html.Label("Select actor"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
Write(Html.DropDownList("ActorId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 22 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>There are no actors left, make a new actor</h3>\r\n");
#nullable restore
#line 27 "C:\Users\ultra\desktop\Filmography\Views\Movies\AddActor.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmography.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
