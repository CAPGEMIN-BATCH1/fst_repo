#pragma checksum "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2832050a191a1124c6479db79cbfa59027c5e751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sam_pract), @"mvc.1.0.view", @"/Views/sam/pract.cshtml")]
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
#line 1 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2832050a191a1124c6479db79cbfa59027c5e751", @"/Views/sam/pract.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_sam_pract : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication5.Models.practice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
 using (Html.BeginForm("pract", "sam", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>enter fst name:</label>\r\n");
#nullable restore
#line 6 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.TextBoxFor(x => x.pname));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationMessageFor(x => x.pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label>  enter last name:</label>\r\n");
#nullable restore
#line 11 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.TextBoxFor(x => x.plname));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationMessageFor(x => x.plname));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label>enter Emailid:</label>\r\n");
#nullable restore
#line 16 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.TextBoxFor(x => x.pmailid));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationMessageFor(x => x.pmailid));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label>enter ph no:</label>\r\n");
#nullable restore
#line 21 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.TextBoxFor(x => x.pcno));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationMessageFor(x => x.pcno));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <label>enter acc nub:</label>\r\n");
#nullable restore
#line 26 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.TextBoxFor(x => x.pacno));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationMessageFor(x => x.pacno));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"login\" />\r\n");
#nullable restore
#line 31 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\satya\source\repos\WebApplication5\WebApplication5\Views\sam\pract.cshtml"
                                  

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication5.Models.practice> Html { get; private set; }
    }
}
#pragma warning restore 1591
