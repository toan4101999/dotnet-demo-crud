#pragma checksum "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0af92ded53a5355ccab444aa077360db81e44b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\MyworkMvc\Views\_ViewImports.cshtml"
using MyworkMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\MyworkMvc\Views\_ViewImports.cshtml"
using MyworkMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0af92ded53a5355ccab444aa077360db81e44b8", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75fc7ae6b5d69bfdda8911237d4b3ee331d06b05", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Page";

    List<Job> jobs = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Welcome To Admin Page
</h1>
<table class=""table table-hover"">
    <thead>
        <th>JobId</th>
        <th>Name Company</th>
        <th>Name Job</th>
        <th>Salary</th>
        <th>Location</th>
        <th>JobImages</th>
        <th>Option</th>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
         foreach (var job in jobs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
               Write(job.JobId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                <th>");
#nullable restore
#line 25 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
               Write(job.nameCompany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 26 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
               Write(job.nameJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 27 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
               Write(job.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 28 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
               Write(job.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>\r\n                    <a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0af92ded53a5355ccab444aa077360db81e44b85716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 762, "~/", 762, 2, true);
#nullable restore
#line 31 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 764, job.imageCompany, 764, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </th>\r\n                <th>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\'", 902, "\'", 936, 2);
            WriteAttributeValue("", 909, "Admin/edit?jobId=", 909, 17, true);
#nullable restore
#line 35 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
WriteAttributeValue("", 926, job.JobId, 926, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\'", 993, "\'", 1029, 2);
            WriteAttributeValue("", 1000, "Admin/delete?jobId=", 1000, 19, true);
#nullable restore
#line 36 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1019, job.JobId, 1019, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\'", 1088, "\'", 1124, 2);
            WriteAttributeValue("", 1095, "Admin/Upload?jobId=", 1095, 19, true);
#nullable restore
#line 37 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1114, job.JobId, 1114, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add+UploadImages</a>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Administrator\MyworkMvc\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-success\" href=\"Admin/add\">Add</a>\r\n\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
