#pragma checksum "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2202487ef57a082776ad0c4e2694ba19465846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjCRS.Pages.Criminals.Pages_Criminals_Details), @"mvc.1.0.razor-page", @"/Pages/Criminals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Criminals/Details.cshtml", typeof(ProjCRS.Pages.Criminals.Pages_Criminals_Details), null)]
namespace ProjCRS.Pages.Criminals
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\_ViewImports.cshtml"
using ProjCRS;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2202487ef57a082776ad0c4e2694ba19465846", @"/Pages/Criminals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aff7ac14c7c9d2b0c63a78067a0d2a523f2613", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Criminals_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Criminal</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 54, false);
#line 15 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 50, false);
#line 18 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 53, false);
#line 21 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 49, false);
#line 24 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 54, false);
#line 27 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(656, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(700, 50, false);
#line 30 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(750, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(794, 51, false);
#line 33 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(889, 47, false);
#line 36 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(936, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(980, 58, false);
#line 39 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1082, 54, false);
#line 42 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1180, 49, false);
#line 45 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.City));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1273, 45, false);
#line 48 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.City));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1362, 50, false);
#line 51 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.State));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1456, 46, false);
#line 54 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.State));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1546, 52, false);
#line 57 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1642, 48, false);
#line 60 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1734, 53, false);
#line 63 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.Employed));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1831, 49, false);
#line 66 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.Employed));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1924, 51, false);
#line 69 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.Income));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2019, 47, false);
#line 72 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.Income));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2110, 59, false);
#line 75 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Criminal.EducationLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2213, 55, false);
#line 78 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Criminal.EducationLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2315, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd41b4dc93534a4fa396e05980fa25f9", async() => {
                BeginContext(2370, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Criminals\Details.cshtml"
                           WriteLiteral(Model.Criminal.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2378, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2386, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bafa3070d29e4ed99b7ed0d3690e4743", async() => {
                BeginContext(2408, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2424, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjCRS.Pages.Criminals.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjCRS.Pages.Criminals.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjCRS.Pages.Criminals.DetailsModel>)PageContext?.ViewData;
        public ProjCRS.Pages.Criminals.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
