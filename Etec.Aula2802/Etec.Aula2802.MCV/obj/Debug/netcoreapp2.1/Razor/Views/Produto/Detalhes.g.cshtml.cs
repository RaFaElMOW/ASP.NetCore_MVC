#pragma checksum "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f625b5d20c209fc0e2a6eb367f0bf828ab625972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Detalhes), @"mvc.1.0.view", @"/Views/Produto/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Detalhes.cshtml", typeof(AspNetCore.Views_Produto_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f625b5d20c209fc0e2a6eb367f0bf828ab625972", @"/Views/Produto/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e3a5d77c432c2532f2c0e27fadaed679d1d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Etec.Aula2802.MCV.Models.Produto>
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
#line 3 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(87, 122, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Produto</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(210, 45, false);
#line 14 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.cdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 41, false);
#line 17 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.cdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 45, false);
#line 20 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.nmProduto));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(473, 41, false);
#line 23 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.nmProduto));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 41, false);
#line 26 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(599, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(643, 37, false);
#line 29 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(724, 45, false);
#line 32 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 41, false);
#line 35 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(854, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(898, 46, false);
#line 38 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 42, false);
#line 41 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1078, 68, false);
#line 46 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Detalhes.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1154, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a000deb3aee946bfb9f96295759a2502", async() => {
                BeginContext(1176, 12, true);
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
            BeginContext(1192, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Etec.Aula2802.MCV.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
