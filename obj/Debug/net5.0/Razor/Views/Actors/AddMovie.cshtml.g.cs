#pragma checksum "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dec28be3dfb99c2899fbf5ae5cc6a16cba277e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_AddMovie), @"mvc.1.0.view", @"/Views/Actors/AddMovie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dec28be3dfb99c2899fbf5ae5cc6a16cba277e4", @"/Views/Actors/AddMovie.cshtml")]
    public class Views_Actors_AddMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmography.Models.Actor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Add a movie</h2>\r\n\r\n<h4>Add a movie to this actor: ");
#nullable restore
#line 9 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
                          Write(Html.DisplayFor(model => model.ActorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
 if(ViewBag.movieList != 0)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
Write(Html.HiddenFor(model => model.ActorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
Write(Html.Label("Select movie"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
Write(Html.DropDownList("MovieId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 21 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no movies to add to this actor</p>\r\n");
#nullable restore
#line 26 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 28 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
Write(Html.ActionLink("Add new Film", "Create", "Movies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 29 "C:\Users\ultra\desktop\Filmography\Views\Actors\AddMovie.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmography.Models.Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591