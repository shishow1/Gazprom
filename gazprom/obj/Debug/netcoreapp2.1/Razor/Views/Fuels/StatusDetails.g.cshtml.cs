#pragma checksum "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1baf29eb12ddf10b2a8e199b624c06c09d400f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fuels_StatusDetails), @"mvc.1.0.view", @"/Views/Fuels/StatusDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fuels/StatusDetails.cshtml", typeof(AspNetCore.Views_Fuels_StatusDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1baf29eb12ddf10b2a8e199b624c06c09d400f", @"/Views/Fuels/StatusDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9506164cd5969979df1d4c2b9aa2b10095b005b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Fuels_StatusDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gazprom.Models.FuelStatus>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
  
    ViewData["Title"] = "Подробная информация";

#line default
#line hidden
            BeginContext(92, 67, true);
            WriteLiteral("\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(160, 38, false);
#line 10 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(198, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(242, 34, false);
#line 13 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(320, 40, false);
#line 16 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(360, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(404, 36, false);
#line 19 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(440, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(484, 47, false);
#line 22 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(575, 43, false);
#line 25 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(618, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(662, 49, false);
#line 28 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerLiter));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(755, 45, false);
#line 31 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.PricePerLiter));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(844, 40, false);
#line 34 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(928, 36, false);
#line 37 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1008, 41, false);
#line 40 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1093, 37, false);
#line 43 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1174, 45, false);
#line 46 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FuelTanks));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 88, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <canvas id=\"myChart\" data-status-details-id=\"");
            EndContext();
            BeginContext(1308, 8, false);
#line 49 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\Fuels\StatusDetails.cshtml"
                                                    Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 94, true);
            WriteLiteral("\" style=\"width: 100%; height: 500px;\"></canvas>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1410, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc49a9b832c441969bc7a90a615f65e2", async() => {
                BeginContext(1433, 5, true);
                WriteLiteral("Назад");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1442, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gazprom.Models.FuelStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591