#pragma checksum "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953b0ef811fab0ef09bc56b73caacba5e4589884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FuelTanks_Details), @"mvc.1.0.view", @"/Views/FuelTanks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FuelTanks/Details.cshtml", typeof(AspNetCore.Views_FuelTanks_Details))]
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
#line 1 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\_ViewImports.cshtml"
using gazprom;

#line default
#line hidden
#line 2 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\_ViewImports.cshtml"
using gazprom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953b0ef811fab0ef09bc56b73caacba5e4589884", @"/Views/FuelTanks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9506164cd5969979df1d4c2b9aa2b10095b005b9", @"/Views/_ViewImports.cshtml")]
    public class Views_FuelTanks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gazprom.Models.FuelTank>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
  
    ViewData["Title"] = "Подробная информация";

#line default
#line hidden
            BeginContext(90, 67, true);
            WriteLiteral("\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(158, 38, false);
#line 10 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(196, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(240, 34, false);
#line 13 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(318, 40, false);
#line 16 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(402, 36, false);
#line 19 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(438, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(482, 41, false);
#line 22 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(567, 37, false);
#line 25 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(604, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(648, 45, false);
#line 28 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fuel.Name));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(737, 41, false);
#line 31 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fuel.Name));

#line default
#line hidden
            EndContext();
            BeginContext(778, 137, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Диаграмма\r\n        </dt>\r\n        <dd>\r\n            <canvas id=\"myChart\" data-fuel-tank-size=\"");
            EndContext();
            BeginContext(916, 10, false);
#line 37 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
                                                 Write(Model.Size);

#line default
#line hidden
            EndContext();
            BeginContext(926, 24, true);
            WriteLiteral("\" data-fuel-tank-value=\"");
            EndContext();
            BeginContext(951, 11, false);
#line 37 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
                                                                                    Write(Model.Value);

#line default
#line hidden
            EndContext();
            BeginContext(962, 90, true);
            WriteLiteral("\" style=\"width: 100%; height: 500px;\"></canvas>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 42 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(1093, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1101, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "982163483df149aaa941e5b0d66d03c4", async() => {
                BeginContext(1147, 13, true);
                WriteLiteral("Редактировать");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
                               WriteLiteral(Model.Id);

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
            BeginContext(1170, 3, true);
            WriteLiteral(" | ");
            EndContext();
#line 44 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\FuelTanks\Details.cshtml"
                                                                                       
    }

#line default
#line hidden
            BeginContext(1189, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1193, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401ea1b5f56f41dd9f86fc57b7886398", async() => {
                BeginContext(1215, 5, true);
                WriteLiteral("Назад");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1224, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gazprom.Models.FuelTank> Html { get; private set; }
    }
}
#pragma warning restore 1591