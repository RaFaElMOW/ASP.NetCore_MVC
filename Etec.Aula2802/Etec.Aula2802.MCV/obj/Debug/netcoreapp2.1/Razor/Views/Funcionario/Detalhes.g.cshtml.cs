#pragma checksum "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6963591e47c8fc3102bdb96a4d1b6197b556741f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Detalhes), @"mvc.1.0.view", @"/Views/Funcionario/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/Detalhes.cshtml", typeof(AspNetCore.Views_Funcionario_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6963591e47c8fc3102bdb96a4d1b6197b556741f", @"/Views/Funcionario/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e3a5d77c432c2532f2c0e27fadaed679d1d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Etec.Aula2802.MCV.Models.Funcionario>
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(91, 126, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Funcionario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(218, 49, false);
#line 14 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.cdFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 45, false);
#line 17 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.cdFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 49, false);
#line 20 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.nmFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(493, 45, false);
#line 23 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.nmFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 44, false);
#line 26 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 40, false);
#line 29 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 44, false);
#line 32 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 40, false);
#line 35 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 38, false);
#line 38 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.rg));

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1008, 34, false);
#line 41 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.rg));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1086, 39, false);
#line 44 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1169, 35, false);
#line 47 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1248, 41, false);
#line 50 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1333, 37, false);
#line 53 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1418, 68, false);
#line 58 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Funcionario\Detalhes.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1494, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f395c016ce246b7ade29a49b5eed031", async() => {
                BeginContext(1516, 12, true);
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
            BeginContext(1532, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Etec.Aula2802.MCV.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
