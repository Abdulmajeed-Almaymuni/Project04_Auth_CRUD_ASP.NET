#pragma checksum "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bdac4112e30cbd58163d6e4e27b42d4eb7e343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_Details), @"mvc.1.0.view", @"/Views/Teachers/Details.cshtml")]
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
#line 1 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bdac4112e30cbd58163d6e4e27b42d4eb7e343", @"/Views/Teachers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Teachers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
  
    Teacher teacher = ViewBag.Teacher;
    ViewData["title"] = "Teacher Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg-light text-center rounded rounded-3 m-auto p-5 col-6\">\r\n");
#nullable restore
#line 6 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
     if (teacher != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>ID: ");
#nullable restore
#line 8 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
          Write(teacher.TeacherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Student Name: ");
#nullable restore
#line 9 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
                    Write(teacher.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
                                       Write(teacher.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Student Email: ");
#nullable restore
#line 10 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
                     Write(teacher.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a href=\"/Teachers\" class=\"btn btn-primary\">Back</a>\r\n");
#nullable restore
#line 12 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Data not found</p>\r\n");
#nullable restore
#line 17 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Teachers\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
