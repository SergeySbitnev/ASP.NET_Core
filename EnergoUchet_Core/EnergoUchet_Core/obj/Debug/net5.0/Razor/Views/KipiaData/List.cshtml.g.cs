#pragma checksum "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2dd6411f235b96337f05f7edf79654895a8e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KipiaData_List), @"mvc.1.0.view", @"/Views/KipiaData/List.cshtml")]
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
#line 1 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\_ViewImports.cshtml"
using EnergoUchet_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\_ViewImports.cshtml"
using EnergoUchet_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2dd6411f235b96337f05f7edf79654895a8e5a", @"/Views/KipiaData/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edda0fb9e7c4afc17c78d3ffb518ae983e009d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_KipiaData_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KipiaData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table>\r\n    <tr>\r\n        <th>");
#nullable restore
#line 6 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 7 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
       Write(Html.DisplayNameFor(model => model.NaturalGas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 8 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
       Write(Html.DisplayNameFor(model => model.ThermalEnergy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 9 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
       Write(Html.DisplayNameFor(model => model.HeatCarrier));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
           Write(p.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
           Write(p.NaturalGas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
           Write(p.ThermalEnergy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
           Write(p.HeatCarrier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\ASP.NET_Core\EnergoUchet_Core\EnergoUchet_Core\Views\KipiaData\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KipiaData>> Html { get; private set; }
    }
}
#pragma warning restore 1591