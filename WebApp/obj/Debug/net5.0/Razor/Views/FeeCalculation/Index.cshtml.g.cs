#pragma checksum "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01d1c23a054f9a178dfcefed5b24d13044fa475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeeCalculation_Index), @"mvc.1.0.view", @"/Views/FeeCalculation/Index.cshtml")]
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
#line 1 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
using WebApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01d1c23a054f9a178dfcefed5b24d13044fa475", @"/Views/FeeCalculation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_FeeCalculation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.ViewModels.PartnerVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .treegrid-indent {
        width: 0px;
        height: 16px;
        display: inline-block;
        position: relative;
    }

    .treegrid-expander {
        width: 0px;
        height: 16px;
        display: inline-block;
        position: relative;
        left: -17px;
        cursor: pointer;
    }
</style>

<div class=""container"">
    <table id=""tree-table"" class=""table table-hover table-bordered"">
        <tbody>
        <th>Partner</th>
        <th>Total shopping amount</th>
        <th>Team shopping amount</th>
        <th>Total commision</th>

");
#nullable restore
#line 35 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
         foreach (PartnerVM.PartnerInfo item in Model.treePartners)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr data-id=\"");
#nullable restore
#line 38 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-parent=\"");
#nullable restore
#line 38 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
                                           Write(item.PartnerParentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-level=\"");
#nullable restore
#line 38 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
                                                                              Write(item.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <td data-column=\"name\">");
#nullable restore
#line 39 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
               Write(item.TotalShoppingAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
               Write(item.TotalTeamAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
               Write(item.TotalCommision);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\FeeCalculation\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.ViewModels.PartnerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
