#pragma checksum "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161fd21a4cbf12f2cce268d7c6aac846fb702a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Lista), @"mvc.1.0.view", @"/Views/Produto/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Lista.cshtml", typeof(AspNetCore.Views_Produto_Lista))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161fd21a4cbf12f2cce268d7c6aac846fb702a78", @"/Views/Produto/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e3a5d77c432c2532f2c0e27fadaed679d1d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Etec.Aula2802.MCV.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h2>Lista</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a524d8a30b2a47febc59ba990b5e88dc", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 45, false);
#line 16 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.cdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 45, false);
#line 19 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.nmProduto));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 41, false);
#line 22 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(555, 45, false);
#line 25 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(656, 46, false);
#line 28 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(702, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(820, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(869, 44, false);
#line 37 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.cdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 44, false);
#line 40 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.nmProduto));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1069, 40, false);
#line 43 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1165, 44, false);
#line 46 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1265, 45, false);
#line 49 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1366, 65, false);
#line 52 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1452, 71, false);
#line 53 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1544, 69, false);
#line 54 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\3binfo\Documents\Rafael\ASP.NetCore_MVC\Etec.Aula2802\Etec.Aula2802.MCV\Views\Produto\Lista.cshtml"
}

#line default
#line hidden
            BeginContext(1652, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Etec.Aula2802.MCV.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591