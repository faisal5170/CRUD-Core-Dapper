#pragma checksum "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f720fbb1f655eb88b5e626e8bab0bda8395d332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Job/Index.cshtml", typeof(AspNetCore.Views_Job_Index))]
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
#line 1 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\_ViewImports.cshtml"
using tempCore;

#line default
#line hidden
#line 2 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\_ViewImports.cshtml"
using tempCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f720fbb1f655eb88b5e626e8bab0bda8395d332", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d54a120bc1d025ffcc9b81f35b5209e7b8bc8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tempCore.Models.POCO.Job>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(80, 1594, true);
            WriteLiteral(@"
<a href=""/Job/Add"" class=""btn btn-primary"">Add</a>
<br />
<table id=""_DataTable"" class=""table compact table-striped table-bordered nowrap dataTable"" aria-describedby=""_DataTable_info"">
    <thead>
        <tr role=""row"">
            <th class=""sorting_asc"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Image: activate to sort column descending"" style=""width: 127px;"">Image</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 209px;"">Title</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""City: activate to sort column ascending"" style=""width: 116px;"">City</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Vacancy: activate to sort colum");
            WriteLiteral(@"n ascending"" style=""width: 127px;"">Vacancy</th>
            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label=""Created Date: activate to sort column ascending"" style=""width: 190px;"">Created Date</th>
            <th style=""width: 38px;"" class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""_DataTable"" rowspan=""1"" colspan=""1"" aria-label="" Action : activate to sort column ascending""> Action </th>
        </tr>
    </thead>
    <tbody role=""alert"" aria-live=""polite"" aria-relevant=""all"">
");
            EndContext();
#line 20 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1723, 79, true);
            WriteLiteral("            <tr class=\"even\">\r\n                <td style=\"text-align:left\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1802, "\"", 1822, 1);
#line 23 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
WriteAttributeValue("", 1808, item.JobImage, 1808, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1823, 87, true);
            WriteLiteral(" alt=\"Image\" width=\"50\" height=\"50\"></td>\r\n                <td style=\"text-align:left\">");
            EndContext();
            BeginContext(1911, 13, false);
#line 24 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
                                       Write(item.JobTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 51, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:left\">");
            EndContext();
            BeginContext(1976, 11, false);
#line 25 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
                                       Write(item.CityId);

#line default
#line hidden
            EndContext();
            BeginContext(1987, 51, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:left\">");
            EndContext();
            BeginContext(2040, 36, false);
#line 26 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
                                        Write(item.IsActive == true ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2077, 52, true);
            WriteLiteral("</td>\r\n                <td style=\"text-align:right\">");
            EndContext();
            BeginContext(2130, 20, false);
#line 27 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
                                        Write(item.CreatedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 72, true);
            WriteLiteral("</td>\r\n                <td class=\"text-center \">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2222, "\"", 2256, 2);
            WriteAttributeValue("", 2229, "/Job/Edit?JobID=", 2229, 16, true);
#line 29 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
WriteAttributeValue("", 2245, item.JobID, 2245, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2257, 52, true);
            WriteLiteral(" title=\"Edit\">Edit  <i class=\"fa fa-edit\"></i></a><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2309, "\"", 2346, 2);
            WriteAttributeValue("", 2316, "/Job/Delete?&JobID=", 2316, 19, true);
#line 29 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
WriteAttributeValue("", 2335, item.JobID, 2335, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2347, 179, true);
            WriteLiteral(" class=\"\" onclick=\"return confirm(\" Are you sure want to delete this job?\");\" title=\"Delete\">Delete     <i class=\"fa fa-times\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\faisa\source\repos\tempCore\tempCore\Views\Job\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2537, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tempCore.Models.POCO.Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
