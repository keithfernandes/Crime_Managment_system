#pragma checksum "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a37e400f466feec1c281ef1f4b8fea31d6f38c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjCRS.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(ProjCRS.Pages.Pages_Contact), null)]
namespace ProjCRS.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a37e400f466feec1c281ef1f4b8fea31d6f38c", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aff7ac14c7c9d2b0c63a78067a0d2a523f2613", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(45, 17, false);
#line 6 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(62, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(74, 13, false);
#line 7 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(87, 624, true);
            WriteLiteral(@"</h3>

<h3><strong><span style =""Color:#811010ec"">Contact Us</span></strong></h3>

<address>
    CRS Corporation<br/>
    228 Park Ave <br/>
    New York, NY, 98052<br/>
</address>

<h3><strong><span style =""Color:#811010ec"">Phone</span></strong></h3>

<address>
    <abbr title=""Phone"">P:</abbr>
    959.565.0100
</address>

<h3><strong><span style =""Color:#811010ec"">Email </span></strong></h3>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@CRSCorp.com"">Support@CRSCorp.com</a><br />
    <strong>Legal:</strong> <a href=""mailto:legal@CRSCorp.com"">Legal@CRSCorp.com</a>
</address>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
