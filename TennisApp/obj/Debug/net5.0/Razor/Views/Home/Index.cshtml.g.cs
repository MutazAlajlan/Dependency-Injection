#pragma checksum "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5136877caac522363477d8c62edb8ca883c4327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\_ViewImports.cshtml"
using TennisApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\_ViewImports.cshtml"
using TennisApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5136877caac522363477d8c62edb8ca883c4327", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eca3bcc5e09c6e4eb164ad7cc7e8f1417b6e7a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TennisApp.Models.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to our Tennis Club";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 6 "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"alert alert-info\" role=\"alert\">\n            <h4>How\'s the weather?</h4>\n            <p>");
#nullable restore
#line 12 "C:\Users\rooke\Desktop\TennisAppA\TennisAppA\TennisApp\Views\Home\Index.cshtml"
          Write(Model.WeatherDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <p>
            We are a friendly and well-equipped tennis club in the sunny seaside town. We cater to players of all standards
            with our award-winning courts and training. Whether you want a friendly game, some serious competition
            or to improve your skills, we are the club for you.
        </p>
        <p>
            We have three fantastic grass courts and for the winter season and rainy days, high quality air-conditioned indoor courts for our premium members. Our
            clubhouse is equipped with changing and shower facilities for those before work sessions!
        </p>
    </div>
</div>

<h3>Want to take a look around?</h3>

<div class=""row"">
    <div class=""col-md-12"">
        <p>
            We offer a free trial day to all prospective members where you can try out the courts and facilities. Our membership starts at only £40
            per month which includes some training time wi");
            WriteLiteral("th our club pro.\n        </p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TennisApp.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
