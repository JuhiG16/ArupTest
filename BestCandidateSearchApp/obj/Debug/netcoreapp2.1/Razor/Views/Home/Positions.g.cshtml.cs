#pragma checksum "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11b6c7016013205fd0703aeb6cbb313b5243695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Positions), @"mvc.1.0.view", @"/Views/Home/Positions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Positions.cshtml", typeof(AspNetCore.Views_Home_Positions))]
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
#line 1 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\_ViewImports.cshtml"
using BestCandidateSearchApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11b6c7016013205fd0703aeb6cbb313b5243695", @"/Views/Home/Positions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c173e316bc873ab1af5fdcb14a381a35145911a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Positions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PositionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
  
    ViewData["Title"] = "Positions";

#line default
#line hidden
            BeginContext(87, 278, true);
            WriteLiteral(@"
<h2>Available Positions</h2>

<table class=""table table-primary"">
    <thead>
        <tr>
            <th>Position Id</th>
            <th>Position Name</th>
            <th>Skills</th>
            <th>search candidate</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
         foreach (var position in Model)
        {

#line default
#line hidden
            BeginContext(418, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(457, 19, false);
#line 22 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
               Write(position.PositionId);

#line default
#line hidden
            EndContext();
            BeginContext(476, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(504, 13, false);
#line 23 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
               Write(position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(517, 42, true);
            WriteLiteral("</td>\r\n               \r\n              <td>");
            EndContext();
            BeginContext(560, 43, false);
#line 25 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
             Write(string.Join(",", position.Skills.ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(603, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(631, 99, false);
#line 26 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
               Write(Html.ActionLink("Search candidate", "SearchCandidate", "Home", new { posId = position.PositionId }));

#line default
#line hidden
            EndContext();
            BeginContext(730, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Jw Villawood\Desktop\Arup\BestCandidateSearchApp\BestCandidateSearchApp\Views\Home\Positions.cshtml"
        }

#line default
#line hidden
            BeginContext(767, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1206, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PositionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
