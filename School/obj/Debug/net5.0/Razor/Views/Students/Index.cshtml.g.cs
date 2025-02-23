#pragma checksum "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52af20745ef2eb9ce199c660e374f99cc7c72d82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52af20745ef2eb9ce199c660e374f99cc7c72d82", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
  
    ViewData["title"] = "Students";
    List<Student> students = (List<Student>)ViewData["Students"];
    bool added = (bool)ViewData["Added"];
    bool deleted = (bool)ViewData["Deleted"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg-light p-5 rounded rounded-3\">\r\n    <div class=\"row justify-content-between\">\r\n        <a href=\"/Students/Create\" class=\"btn btn-success text-center col-2 my-auto\">Add New Student</a>\r\n        ");
#nullable restore
#line 10 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
   Write(await Html.PartialAsync("/Views/Shared/_SearchPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    \r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
     if (added == true)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success \">Student Added Successfully</div>\r\n");
#nullable restore
#line 19 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
    }
    else if (deleted == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success \">Student Deleted Successfully</div>\r\n");
#nullable restore
#line 23 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
     if (students.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-dark"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 38 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                 foreach (var student in students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 41 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                                   Write(student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                       Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                       Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                       Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1562, "\"", 1605, 2);
            WriteAttributeValue("", 1569, "/Students/Details/", 1569, 18, true);
#nullable restore
#line 46 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
WriteAttributeValue("", 1587, student.StudentId, 1587, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View</a> |\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1673, "\"", 1713, 2);
            WriteAttributeValue("", 1680, "/Students/Edit/", 1680, 15, true);
#nullable restore
#line 47 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
WriteAttributeValue("", 1695, student.StudentId, 1695, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a> |\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1781, "\"", 1823, 2);
            WriteAttributeValue("", 1788, "/Students/Delete/", 1788, 17, true);
#nullable restore
#line 48 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
WriteAttributeValue("", 1805, student.StudentId, 1805, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 54 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No students found</p>\r\n");
#nullable restore
#line 58 "C:\Users\b0c0a\Source\Repos\Project04_Auth_CRUD_ASP.NET\School\Views\Students\Index.cshtml"
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
