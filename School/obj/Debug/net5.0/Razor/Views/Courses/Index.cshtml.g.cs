#pragma checksum "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932b178c941709c64403280b38c0eb057fbe11af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b178c941709c64403280b38c0eb057fbe11af", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
  
    ViewData["title"] = "Courses";
    List<Course> courses = (List<Course>)ViewData["Courses"];
    bool added = (bool)ViewData["Added"];
    bool deleted = (bool)ViewData["Deleted"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg-light p-5 rounded rounded-3\">\r\n    <div class=\"row justify-content-around\">\r\n        <a href=\"/Courses/Create\" class=\"btn btn-success  text-center col-2 my-auto\">Add New Course</a>\r\n        ");
#nullable restore
#line 10 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
   Write(await Html.PartialAsync("/Views/Shared/_SearchPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
     if (added == true)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success \">Course Added Successfully</div>\r\n");
#nullable restore
#line 16 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
    }
    else if (deleted == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success \">Course Deleted Successfully</div>\r\n");
#nullable restore
#line 20 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
     if (courses.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-dark w-75 mx-auto"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Course Title</th>

                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
                 foreach (var course in courses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 37 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
                                   Write(course.CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
                       Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1369, 2);
            WriteAttributeValue("", 1336, "/Courses/Details/", 1336, 17, true);
#nullable restore
#line 40 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
WriteAttributeValue("", 1353, course.CourseId, 1353, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View</a> |\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1437, "\"", 1474, 2);
            WriteAttributeValue("", 1444, "/Courses/Edit/", 1444, 14, true);
#nullable restore
#line 41 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
WriteAttributeValue("", 1458, course.CourseId, 1458, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a> |\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1581, 2);
            WriteAttributeValue("", 1549, "/Courses/Delete/", 1549, 16, true);
#nullable restore
#line 42 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
WriteAttributeValue("", 1565, course.CourseId, 1565, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 48 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No courses found</p>\r\n");
#nullable restore
#line 52 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Courses\Index.cshtml"
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
