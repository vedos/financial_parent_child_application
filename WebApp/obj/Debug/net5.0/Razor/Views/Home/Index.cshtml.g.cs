#pragma checksum "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838c4ca1bd8cb88b9740052887284dbce1b86e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838c4ca1bd8cb88b9740052887284dbce1b86e1f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.FinancialVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Partner</th>
                <th scope=""col"">Amount</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
             foreach (FinancialVM.FinancialItemVM x in Model.financialItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">1</th>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
                   Write(x.Partner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
                   Write(x.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
                   Write(x.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 848, 2);
            WriteAttributeValue("", 828, "Home/Delete?ID=", 828, 15, true);
#nullable restore
#line 27 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 843, x.Id, 843, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"");
            BeginWriteAttribute("id", " id=\"", 872, "\"", 889, 2);
            WriteAttributeValue("", 877, "delete_", 877, 7, true);
#nullable restore
#line 27 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 884, x.Id, 884, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return Submit(this.id)\">Remove</a>\r\n                        <a href=\"#\" class=\"btn btn-info\"");
            BeginWriteAttribute("id", " id=\"", 992, "\"", 1007, 2);
            WriteAttributeValue("", 997, "edit_", 997, 5, true);
#nullable restore
#line 28 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1002, x.Id, 1002, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1031, "\"", 1059, 4);
            WriteAttributeValue("", 1041, "return", 1041, 6, true);
            WriteAttributeValue(" ", 1047, "Edit(", 1048, 6, true);
#nullable restore
#line 28 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1053, x.Id, 1053, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1058, ")", 1058, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\vedo_\Source\Repos\financial_mvc_application\WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table>

</div>


<p>
    <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"" onclick=""return Edit(0)"">
        Add
    </a>
</p>
<div class=""collapse col-md-6"" id=""collapseExample"">
    <div class=""card card-body "">
        <div id=""divAdd"" class=""form-group"">
            <!--place for Add partial-->
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838c4ca1bd8cb88b9740052887284dbce1b86e1f8070", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    function Submit(id) {
        if (confirm(""Do you really want to delete this?"")) {
            return true;
        }
        else {
            return false;
        }
        return true;
    }

    function Edit(value) {
        $('#divAdd').load('/Home/Edit?Id=' + value);
        $('#collapseExample').collapse();
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.FinancialVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
