#pragma checksum "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df1597a5e5fb83720e16b12dfb2536d020b2d7c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Dashboard), @"mvc.1.0.view", @"/Views/Dashboard/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Dashboard.cshtml", typeof(AspNetCore.Views_Dashboard_Dashboard))]
namespace AspNetCore
{
    #line hidden
#line 1 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
using System;

#line default
#line hidden
#line 2 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\CodingDojo\WeddingPlannerExample\Views\_ViewImports.cshtml"
using LoginReg;

#line default
#line hidden
#line 2 "D:\CodingDojo\WeddingPlannerExample\Views\_ViewImports.cshtml"
using LoginReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1597a5e5fb83720e16b12dfb2536d020b2d7c8", @"/Views/Dashboard/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cffb413b3ff31940133525c56529196ca370a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(95, 946, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80db1f98fa8d463d8bc4ff6611e7280a", async() => {
                BeginContext(101, 137, true);
                WriteLiteral("\r\n    <h1>Welcome to Dojo Activity Center!</h1>\r\n    <a href = \"/add/activity\">Add Activity</a> \r\n    <a href = \"/logout\">Logout</a> \r\n\r\n");
                EndContext();
#line 10 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
     foreach (var w in Model)
    {

#line default
#line hidden
                BeginContext(276, 13, true);
                WriteLiteral("        <p><a");
                EndContext();
                BeginWriteAttribute("href", " href = \"", 289, "\"", 316, 2);
                WriteAttributeValue("", 298, "/view/", 298, 6, true);
#line 12 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 304, w.WeddingId, 304, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(317, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(319, 14, false);
#line 12 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                                     Write(w.WeddingTitle);

#line default
#line hidden
                EndContext();
                BeginContext(333, 12, true);
                WriteLiteral(" </a> Date: ");
                EndContext();
                BeginContext(346, 33, false);
#line 12 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                                                                Write(w.WeddingDate.ToString("MMMM dd"));

#line default
#line hidden
                EndContext();
                BeginContext(379, 4, true);
                WriteLiteral(" at ");
                EndContext();
                BeginContext(384, 26, false);
#line 12 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                                                                                                      Write(w.Time.ToString("h:mm tt"));

#line default
#line hidden
                EndContext();
                BeginContext(410, 23, true);
                WriteLiteral("\r\n         | Duration: ");
                EndContext();
                BeginContext(434, 10, false);
#line 13 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                Write(w.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(444, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(446, 10, false);
#line 13 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                            Write(w.TimeType);

#line default
#line hidden
                EndContext();
                BeginContext(456, 22, true);
                WriteLiteral(" | Event Coordinator: ");
                EndContext();
                BeginContext(479, 13, false);
#line 13 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                                                             Write(w.CreatorName);

#line default
#line hidden
                EndContext();
                BeginContext(492, 17, true);
                WriteLiteral(" | Participants: ");
                EndContext();
                BeginContext(510, 14, false);
#line 13 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                                                                                            Write(w.Guests.Count);

#line default
#line hidden
                EndContext();
                BeginContext(524, 26, true);
                WriteLiteral(" | \r\n            Action:\r\n");
                EndContext();
#line 15 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
             if(@w.UserId == @ViewBag.UserId)
            {

#line default
#line hidden
                BeginContext(612, 18, true);
                WriteLiteral("                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 630, "\"", 657, 2);
                WriteAttributeValue("", 637, "/delete/", 637, 8, true);
#line 17 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 645, w.WeddingId, 645, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(658, 13, true);
                WriteLiteral(">Delete</a>\r\n");
                EndContext();
#line 18 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
            }else{
                

#line default
#line hidden
#line 19 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                 if(w.Guests.Any (g => g.UserId == @ViewBag.UserId))
                {

#line default
#line hidden
                BeginContext(780, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 802, "\"", 836, 2);
                WriteAttributeValue("", 809, "/leave/wedding/", 809, 15, true);
#line 21 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 824, w.WeddingId, 824, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(837, 12, true);
                WriteLiteral(">Leave</a>\r\n");
                EndContext();
#line 22 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                }else
                {

#line default
#line hidden
                BeginContext(891, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 913, "\"", 946, 2);
                WriteAttributeValue("", 920, "/join/wedding/", 920, 14, true);
#line 24 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 934, w.WeddingId, 934, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(947, 12, true);
                WriteLiteral(">Join</a> \r\n");
                EndContext();
#line 25 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                }

#line default
#line hidden
#line 25 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(993, 28, true);
                WriteLiteral("            \r\n        </p>\r\n");
                EndContext();
#line 29 "D:\CodingDojo\WeddingPlannerExample\Views\Dashboard\Dashboard.cshtml"
    }

#line default
#line hidden
                BeginContext(1028, 6, true);
                WriteLiteral("    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
