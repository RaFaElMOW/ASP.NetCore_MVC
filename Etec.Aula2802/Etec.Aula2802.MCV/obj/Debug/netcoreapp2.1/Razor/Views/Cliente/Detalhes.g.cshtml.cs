#pragma checksum "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb3769dc78fe48bb06be0f7edacaab6a1944764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Detalhes), @"mvc.1.0.view", @"/Views/Cliente/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Detalhes.cshtml", typeof(AspNetCore.Views_Cliente_Detalhes))]
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
#line 1 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\_ViewImports.cshtml"
using Etec.Aula2802.MCV;

#line default
#line hidden
#line 2 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\_ViewImports.cshtml"
using Etec.Aula2802.MCV.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb3769dc78fe48bb06be0f7edacaab6a1944764", @"/Views/Cliente/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e3a5d77c432c2532f2c0e27fadaed679d1d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Etec.Aula2802.MCV.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(87, 122, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(210, 45, false);
#line 14 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.cdCliente));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 41, false);
#line 17 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.cdCliente));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 45, false);
#line 20 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.nmCliente));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(473, 41, false);
#line 23 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.nmCliente));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 48, false);
#line 26 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.dtNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(650, 44, false);
#line 29 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.dtNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(694, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(738, 40, false);
#line 32 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.peso));

#line default
#line hidden
            EndContext();
            BeginContext(778, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(822, 36, false);
#line 35 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.peso));

#line default
#line hidden
            EndContext();
            BeginContext(858, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(906, 68, false);
#line 40 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Cliente\Detalhes.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(974, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(982, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef075cfb9ceb46b980f88976b2c3794d", async() => {
                BeginContext(1004, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1020, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Etec.Aula2802.MCV.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591