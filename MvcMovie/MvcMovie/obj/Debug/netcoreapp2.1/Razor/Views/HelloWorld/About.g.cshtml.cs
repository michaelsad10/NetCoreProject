#pragma checksum "/Users/michaelsadaghyani/Projects/MvcMovie/MvcMovie/Views/HelloWorld/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "419c8988f7027780db514b9e8aa1acb899c4d7de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_About), @"mvc.1.0.view", @"/Views/HelloWorld/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/About.cshtml", typeof(AspNetCore.Views_HelloWorld_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419c8988f7027780db514b9e8aa1acb899c4d7de", @"/Views/HelloWorld/About.cshtml")]
    public class Views_HelloWorld_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 63, true);
            WriteLiteral("<h2>About</h2>\r\n\r\n<p>Hello this is the About page</p>\r\n\r\n<ul>\r\n");
            EndContext();
#line 6 "/Users/michaelsadaghyani/Projects/MvcMovie/MvcMovie/Views/HelloWorld/About.cshtml"
     for (int i = 0; i < (int)ViewData["Rate"]; i++)
    {

#line default
#line hidden
            BeginContext(124, 13, true);
            WriteLiteral("        <li> ");
            EndContext();
            BeginContext(138, 16, false);
#line 8 "/Users/michaelsadaghyani/Projects/MvcMovie/MvcMovie/Views/HelloWorld/About.cshtml"
        Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(154, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(174, 15, false);
#line 9 "/Users/michaelsadaghyani/Projects/MvcMovie/MvcMovie/Views/HelloWorld/About.cshtml"
       Write(ViewData["Age"]);

#line default
#line hidden
            EndContext();
            BeginContext(189, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "/Users/michaelsadaghyani/Projects/MvcMovie/MvcMovie/Views/HelloWorld/About.cshtml"
    }

#line default
#line hidden
            BeginContext(203, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591