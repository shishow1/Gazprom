#pragma checksum "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0b4ba7aa0f9b77837bbc4cf318690f344f2540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IncomeAndExpenses_Details), @"mvc.1.0.view", @"/Views/IncomeAndExpenses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IncomeAndExpenses/Details.cshtml", typeof(AspNetCore.Views_IncomeAndExpenses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0b4ba7aa0f9b77837bbc4cf318690f344f2540", @"/Views/IncomeAndExpenses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9506164cd5969979df1d4c2b9aa2b10095b005b9", @"/Views/_ViewImports.cshtml")]
    public class Views_IncomeAndExpenses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gazprom.Models.IncomeAndExpense>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
  
    ViewData["Title"] = "Подробная информация";

#line default
#line hidden
            BeginContext(98, 67, true);
            WriteLiteral("\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(166, 38, false);
#line 10 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(204, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(248, 34, false);
#line 13 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(282, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(326, 41, false);
#line 16 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(411, 37, false);
#line 19 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(492, 40, false);
#line 22 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(576, 36, false);
#line 25 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(612, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(656, 44, false);
#line 28 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FuelTank));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(744, 43, false);
#line 31 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.FuelTank.Id));

#line default
#line hidden
            EndContext();
            BeginContext(787, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(831, 40, false);
#line 34 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(871, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(915, 39, false);
#line 37 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 42 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(1038, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1046, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a2c1dcae878433b94f4fd77b2dc4588", async() => {
                BeginContext(1092, 13, true);
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
#line 44 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
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
            BeginContext(1115, 3, true);
            WriteLiteral(" | ");
            EndContext();
#line 44 "C:\Users\Aliaksandr_Viarheich\Desktop\dfg\dfg\dfg\dfg\dfg\gazprom\gazprom\Views\IncomeAndExpenses\Details.cshtml"
                                                                                       
    }

#line default
#line hidden
            BeginContext(1134, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1138, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f746a334ea42b8b021e59b7646a194", async() => {
                BeginContext(1160, 5, true);
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
            BeginContext(1169, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gazprom.Models.IncomeAndExpense> Html { get; private set; }
    }
}
#pragma warning restore 1591
