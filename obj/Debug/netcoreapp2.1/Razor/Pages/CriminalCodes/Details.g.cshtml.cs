#pragma checksum "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74654187b3bdd5d4bc2132414b4bb671fa6e0ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjCRS.Pages.CriminalCodes.Pages_CriminalCodes_Details), @"mvc.1.0.razor-page", @"/Pages/CriminalCodes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CriminalCodes/Details.cshtml", typeof(ProjCRS.Pages.CriminalCodes.Pages_CriminalCodes_Details), null)]
namespace ProjCRS.Pages.CriminalCodes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74654187b3bdd5d4bc2132414b4bb671fa6e0ea", @"/Pages/CriminalCodes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aff7ac14c7c9d2b0c63a78067a0d2a523f2613", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CriminalCodes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 127, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Criminal Code</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(229, 53, false);
#line 15 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CriminalCode.Code));

#line default
#line hidden
            EndContext();
            BeginContext(282, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(326, 49, false);
#line 18 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.CriminalCode.Code));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 60, false);
#line 21 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CriminalCode.Description));

#line default
#line hidden
            EndContext();
            BeginContext(479, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(523, 56, false);
#line 24 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.CriminalCode.Description));

#line default
#line hidden
            EndContext();
            BeginContext(579, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(626, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d274fd0ee70145b092b08f21daf6c4cf", async() => {
                BeginContext(685, 4, true);
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
#line 29 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\CriminalCodes\Details.cshtml"
                           WriteLiteral(Model.CriminalCode.Id);

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
            BeginContext(693, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(701, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e380913238b949de9cf1dbeee48228ad", async() => {
                BeginContext(723, 12, true);
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
            BeginContext(739, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjCRS.Pages.CriminalCodes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjCRS.Pages.CriminalCodes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjCRS.Pages.CriminalCodes.DetailsModel>)PageContext?.ViewData;
        public ProjCRS.Pages.CriminalCodes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
